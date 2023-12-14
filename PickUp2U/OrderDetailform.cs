using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace PickUp2U
{
    public partial class OrderDetailform : Form
    {
        public int userId;
        private bool eventsRegistered = false;
        string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";

        public OrderDetailform(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // 이벤트 핸들러 등록
            if (!eventsRegistered)
            {
                deleteBtn.Click += deleteBtn_Click;
                deleteBtn.Click -= deleteBtn_Click;
                dataGridViewOrders.CellClick += dataGridViewOrders_CellClick;
                eventsRegistered = true;
            }
        }

        private void showlistBtn_Click(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    SELECT O.ORDER_TIME, PO.ORDER_ID, P.PRODUCT_NAME, PO.ORDER_QUANTITY, PO.TOTAL
                    FROM ORDERS O
                    INNER JOIN PRODUCT_ORDERS PO ON O.ORDER_ID = PO.ORDER_ID
                    INNER JOIN PRODUCTS P ON PO.PRODUCT_ID = P.PRODUCT_ID
                    WHERE O.USER_ID = " + userId;

                    using (OracleDataAdapter adapter = new OracleDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);

                        dataGridViewOrders.DataSource = orderTable;
                        dataGridViewOrders.Columns["ORDER_TIME"].HeaderText = "주문 일시";
                        dataGridViewOrders.Columns["ORDER_ID"].HeaderText = "주문 번호";
                        dataGridViewOrders.Columns["PRODUCT_NAME"].HeaderText = "주문 제품";
                        dataGridViewOrders.Columns["ORDER_QUANTITY"].HeaderText = "주문 수량";
                        dataGridViewOrders.Columns["TOTAL"].HeaderText = "총합";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOrders.Rows[e.RowIndex];

                textBox1.Text = row.Cells["ORDER_TIME"].Value.ToString();
                textBox2.Text = row.Cells["ORDER_ID"].Value.ToString();
                textBox3.Text = row.Cells["PRODUCT_NAME"].Value.ToString();
                textBox4.Text = row.Cells["ORDER_QUANTITY"].Value.ToString();
                textBox5.Text = row.Cells["TOTAL"].Value.ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // 확인 다이얼로그 표시
            Console.WriteLine("deleteBtn_Click called");

            DialogResult result = MessageBox.Show("주문 내역을 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 선택된 주문 삭제
                int orderId = Convert.ToInt32(textBox2.Text);

                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        connection.Open();

                        using (OracleTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // 자식 레코드 삭제: PICKUP_PROGRESS, PAYMENTS, PRODUCT_ORDERS    
                                string deleteChildQuery1 = "DELETE FROM PICKUP_PROGRESS WHERE PAYMENT_ID IN (SELECT PAYMENT_ID FROM PAYMENTS WHERE ORDER_ID = :orderId)";
                                using (OracleCommand childCommand1 = new OracleCommand(deleteChildQuery1, connection))
                                {
                                    childCommand1.Parameters.Add(new OracleParameter("orderId", orderId));
                                    childCommand1.ExecuteNonQuery();
                                }

                                string deleteChildQuery2 = "DELETE FROM PAYMENTS WHERE ORDER_ID = :orderId";
                                using (OracleCommand childCommand2 = new OracleCommand(deleteChildQuery2, connection))
                                {
                                    childCommand2.Parameters.Add(new OracleParameter("orderId", orderId));
                                    childCommand2.ExecuteNonQuery();
                                }

                                string deleteChildQuery3 = "DELETE FROM PRODUCT_ORDERS WHERE ORDER_ID = :orderId";
                                using (OracleCommand childCommand3 = new OracleCommand(deleteChildQuery3, connection))
                                {
                                    childCommand3.Parameters.Add(new OracleParameter("orderId", orderId));
                                    childCommand3.ExecuteNonQuery();
                                }

                                // 부모 레코드 삭제: ORDERS
                                string deleteQuery = "DELETE FROM ORDERS WHERE ORDER_ID = :orderId";
                                using (OracleCommand command = new OracleCommand(deleteQuery, connection))
                                {
                                    command.Parameters.Add(new OracleParameter("orderId", orderId));
                                    command.ExecuteNonQuery();
                                }

                                // 트랜잭션 커밋
                                transaction.Commit();

                                MessageBox.Show("주문 내역이 성공적으로 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // 주문 내역 다시 로드
                                LoadOrderHistory();
                            }
                            catch (Exception ex)
                            {
                                // 트랜잭션 롤백
                                transaction.Rollback();

                                MessageBox.Show("트랜잭션 오류: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("연결 오류: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
