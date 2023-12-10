using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            deleteBtn.Click -= deleteBtn_Click;
            deleteBtn.Click += deleteBtn_Click;

            dataGridViewOrders.CellClick -= dataGridViewOrders_CellClick;
            dataGridViewOrders.CellClick += dataGridViewOrders_CellClick;

            eventsRegistered = true;
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

                        // 자식 레코드 삭제
                        string deleteChildQuery = "DELETE FROM PRODUCT_ORDERS WHERE ORDER_ID = :orderId";
                        using (OracleCommand childCommand = new OracleCommand(deleteChildQuery, connection))
                        {
                            childCommand.Parameters.Add(new OracleParameter("orderId", orderId));
                            childCommand.ExecuteNonQuery();
                        }

                        // 부모 레코드 삭제
                        string deleteQuery = "DELETE FROM ORDERS WHERE ORDER_ID = :orderId";
                        using (OracleCommand command = new OracleCommand(deleteQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("orderId", orderId));
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("주문 내역이 성공적으로 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 주문 내역 다시 로드
                        LoadOrderHistory();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}