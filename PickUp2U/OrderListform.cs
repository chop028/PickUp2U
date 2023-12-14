using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace PickUp2U
{
    public partial class OrderListForm : Form
    {
        string connectionString = "User Id=admin;Password=admin;Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER =DEDICATED)(SERVICE_NAME = xe)) )";
        public int userId;
        private int shopId;

        public OrderListForm()
        {
            InitializeComponent();
        }

        // ... (기존 코드)

        private void BtnOrderView_Click(object sender, EventArgs e)
        {
            // DataGridView 초기화
            OrderView.Rows.Clear();
            OrderView.Columns.Clear();

            // DataGridView 컬럼 추가
            OrderView.Columns.Add("Order_Id", "주문 ID");
            OrderView.Columns.Add("Product_Name", "제품 이름");
            OrderView.Columns.Add("Order_Quantity", "주문 수량");
            OrderView.Columns.Add("Order_Amount", "주문 금액");
            OrderView.Columns.Add("Total", "총 금액");

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    // OrderView 버튼 클릭 시 Product_Orders 테이블 조회
                    string query = "SELECT PO.ORDER_ID, P.PRODUCT_NAME, PO.ORDER_QUANTITY, PO.ORDER_AMOUNT, PO.TOTAL " +
                                   "FROM PRODUCTS P " +
                                   "JOIN PRODUCT_ORDERS PO ON P.PRODUCT_ID = PO.PRODUCT_ID " +
                                   "JOIN ORDERS O ON PO.ORDER_ID = O.ORDER_ID " +
                                   "WHERE O.USER_ID = :UserId AND O.SHOP_ID = :ShopId";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // UserId와 ShopId를 파라미터로 전달
                        command.Parameters.Add(":UserId", OracleDbType.Int32).Value = userId;
                        command.Parameters.Add(":ShopId", OracleDbType.Int32).Value = shopId;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // DataGridView에 데이터 추가
                                OrderView.Rows.Add(reader["ORDER_ID"], reader["Product_Name"], reader["Order_Quantity"], reader["Order_Amount"], reader["Total"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ... (다른 메서드 및 이벤트 핸들러 참조)
    }
}