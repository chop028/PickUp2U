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

        public OrderListForm()
        {
            InitializeComponent();
        }
        private void BtnOrderView_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                OracleDataAdapter ordersAdapter = new OracleDataAdapter();
                DataTable ordersTable = new DataTable();

                try
                {
                    connection.Open();

                    string ordersQuery = $"SELECT ORDERS.ORDER_ID, ORDERS.SHOP_ID, SHOPS.SHOP_NAME, PRODUCTS.PRODUCT_NAME " +
                                         $"FROM ORDERS " +
                                         $"INNER JOIN SHOPS ON ORDERS.SHOP_ID = SHOPS.SHOP_ID " +
                                         $"INNER JOIN SHOP_PRODUCTS ON SHOPS.SHOP_ID = SHOP_PRODUCTS.SHOP_ID " +
                                         $"INNER JOIN PRODUCTS ON SHOP_PRODUCTS.PRODUCT_ID = PRODUCTS.PRODUCT_ID " +
                                         $"WHERE SHOPS.USER_ID = {userId}";

                    OracleCommand ordersCommand = new OracleCommand(ordersQuery, connection);
                    ordersAdapter.SelectCommand = ordersCommand;
                    ordersAdapter.Fill(ordersTable);

                    if (ordersTable.Rows.Count > 0)
                    {
                        List<int> orderIds = new List<int>();
                        List<string> shopNames = new List<string>();
                        List<string> productNames = new List<string>();

                        foreach (DataRow row in ordersTable.Rows)
                        {
                            int orderId = Convert.ToInt32(row["ORDER_ID"]);
                            orderIds.Add(orderId);

                            string shopName = row["SHOP_NAME"].ToString();
                            shopNames.Add(shopName);

                            string productName = row["PRODUCT_NAME"].ToString();
                            productNames.Add(productName);
                        }

                        DataTable productOrdersTable = new DataTable();

                        string productOrdersQuery = "SELECT ORDER_ID, ORDER_QUANTITY, ORDER_AMOUNT, TOTAL FROM PRODUCT_ORDERS WHERE ORDER_ID IN (" + string.Join(",", orderIds) + ")";
                        OracleDataAdapter productOrdersAdapter = new OracleDataAdapter(productOrdersQuery, connection);
                        productOrdersAdapter.Fill(productOrdersTable);

                        productOrdersTable.Columns.Add("SHOP_NAME", typeof(string));
                        productOrdersTable.Columns.Add("PRODUCT_NAME", typeof(string));

                        for (int i = 0; i < orderIds.Count; i++)
                        {
                            productOrdersTable.Rows[i]["SHOP_NAME"] = shopNames[i];
                            productOrdersTable.Rows[i]["PRODUCT_NAME"] = productNames[i];
                        }

                        productOrdersTable = productOrdersTable.DefaultView.ToTable(false, "ORDER_ID", "SHOP_NAME", "PRODUCT_NAME", "ORDER_AMOUNT", "ORDER_QUANTITY", "TOTAL");

                        productOrdersTable.Columns["ORDER_ID"].ColumnName = "주문 번호";
                        productOrdersTable.Columns["SHOP_NAME"].ColumnName = "매장명";
                        productOrdersTable.Columns["PRODUCT_NAME"].ColumnName = "상품명";
                        productOrdersTable.Columns["ORDER_AMOUNT"].ColumnName = "상품 가격";
                        productOrdersTable.Columns["ORDER_QUANTITY"].ColumnName = "주문 수량";
                        productOrdersTable.Columns["TOTAL"].ColumnName = "총합";

                        OrderView.DataSource = productOrdersTable;
                    }
                    else
                    {
                        MessageBox.Show("해당 사용자의 상점 정보가 없습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류: " + ex.Message);
                }
            }
        }

    }
}