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
    public partial class Searchform : Form
    {
        SearchDBClass dbSc;

        public static int userId;

        public Searchform()
        {
            InitializeComponent();

            string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)))";
            string query = "SELECT * FROM SHOPS WHERE SHOP_STATUS = 0";

            OracleDataAdapter adapter = new OracleDataAdapter(query, connectionString);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            // DataGridView인 sc_hold에 데이터 표시
            sc_hold.DataSource = dataTable;

        }
        private void sc_Pdlist_Click(object sender, EventArgs e)
        {
        }

        private void sc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string shopId = sc_item.Text;

                shop_num.Text = sc_item.Text;

                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)))";
                string query = $"SELECT PRODUCT_ID FROM SHOPS WHERE SHOP_ID = '{shopId}'";


                OracleDataAdapter adapter = new OracleDataAdapter(query, connectionString);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    string productId = dataTable.Rows[0]["PRODUCT_ID"].ToString();

                    string productQuery = $"SELECT * FROM PRODUCTS WHERE PRODUCT_ID IN (SELECT PRODUCT_ID FROM SHOP_PRODUCTS WHERE SHOP_ID = '{shopId}')";

                    OracleDataAdapter productAdapter = new OracleDataAdapter(productQuery, connectionString);
                    DataTable productDataTable = new DataTable();

                    productAdapter.Fill(productDataTable);

                    sc_list.DataSource = productDataTable;
                }
                else
                {
                    MessageBox.Show("해당하는 제품이 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sc_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0 && rowIndex < sc_list.Rows.Count)
                {
                    string productId = sc_list.Rows[rowIndex].Cells["PRODUCT_ID"].Value.ToString();

                    sc_Productid.Text = productId;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sc_Pdin_Click(object sender, EventArgs e)
        {

        }

        private void sc_basket_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<string> basket_arr = new List<string> { };
        List<string> basket_num_arr = new List<string> { };
        List<string> basket_price_arr = new List<string> { };

        int totalLB = 0;
        private void sc_in_Click(object sender, EventArgs e)
        {
            try
            {
                string productId = sc_Productid.Text;

                int existingIndex = basket_arr.IndexOf(productId);


                if (existingIndex != -1)
                {
                    int num = int.Parse(basket_num_arr[existingIndex]) + 1;
                    basket_num_arr[existingIndex] = num.ToString();
                }
                else
                {
                    basket_arr.Add(productId);
                    basket_num_arr.Add("1");

                    SearchDB2Class searchDB = new SearchDB2Class();
                    searchDB.DB_Open();

                    DataView productView = new DataView(searchDB.PhoneTable);
                    productView.RowFilter = $"CONVERT(PRODUCT_ID, 'System.String') = '{productId}'";

                    if (productView.Count > 0)
                    {
                        string productPrice = productView[0]["PRICE"].ToString();
                        int price = int.Parse(productPrice);
                        int quantity = int.Parse(basket_num_arr[basket_arr.Count - 1]);
                        int totalPrice = price * quantity;

                        basket_price_arr.Add(totalPrice.ToString());
                    }
                }

                sc_basket.Items.Clear();

                for (int i = 0; i < basket_arr.Count; i++)
                {
                    SearchDB2Class searchDB = new SearchDB2Class();
                    searchDB.DB_Open();
                    DataView productView = new DataView(searchDB.PhoneTable);
                    productView.RowFilter = $"CONVERT(PRODUCT_ID, 'System.String') = '{basket_arr[i]}'";

                    if (productView.Count > 0)
                    {
                        string productName = productView[0]["PRODUCT_NAME"].ToString();
                        string basketNum = basket_num_arr[i];
                        //string totalPrice = basket_price_arr[i];

                        int productPrice = int.Parse(basket_price_arr[i]);
                        int quantity = int.Parse(basket_num_arr[i]);
                        int totalPrice = productPrice * quantity;

                        sc_basket.Items.Add($"{basket_arr[i]} : {productName} ({basketNum}) : {totalPrice}");




                        int totalPriceC = 0;
                        for (int j = 0; j < basket_arr.Count; j++)
                        {
                            int pPrice = int.Parse(basket_price_arr[j]);
                            int pquantity = int.Parse(basket_num_arr[j]);

                            totalPriceC += pPrice * pquantity;
                        }

                        sc_total.Text = "총 금액 :" + totalPriceC.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sc_basket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sc_pay_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) )";

                using (var connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string getMaxProductOrderIdQuery = "SELECT MAX(PRODUCT_ORDER_ID) FROM PRODUCT_ORDERS";

                    using (var maxProductOrderIdCommand = new OracleCommand(getMaxProductOrderIdQuery, connection))
                    {

                        string getMaxIdQuery = "SELECT MAX(ORDER_ID) FROM ORDERS";

                        using (var command = new OracleCommand(getMaxIdQuery, connection))
                        {
                            object result = command.ExecuteScalar();

                            int newOrderId = 1;

                            if (result != DBNull.Value)
                            {
                                newOrderId = Convert.ToInt32(result) + 1;
                            }

                            DateTime currentTime = DateTime.Now;
                            string formattedDate = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
                            int shopId = int.Parse(shop_num.Text);

                            string insertQuery = $"INSERT INTO ORDERS (ORDER_ID, USER_ID, SHOP_ID, ORDER_TIME) VALUES ({newOrderId}, '{userId}', {shopId}, TO_TIMESTAMP('{formattedDate}', 'YYYY-MM-DD HH24:MI:SS'))";

                            using (var insertCommand = new OracleCommand(insertQuery, connection))
                            {
                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                MessageBox.Show("제품 주문이 완료되었습니다.");

                                object productOrderIdResult = maxProductOrderIdCommand.ExecuteScalar();
                                int productOrderId = 40000;

                                if (productOrderIdResult != DBNull.Value)
                                {
                                    productOrderId = Convert.ToInt32(productOrderIdResult) + 1;
                                }

                                inesrtPRODUCT_ORDERS(newOrderId,productOrderId);
                                /*             ORDERS 테이블 insert                     */
                           

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   

        private void inesrtPRODUCT_ORDERS(int orderID, int productOrderID)
        {
            //MessageBox.Show("neworder id = " + orderID.ToString());
            //MessageBox.Show("productOrder id = " + productOrderID.ToString());
            //MessageBox.Show("basket_num_arr = " + basket_num_arr.Count); 
            /*
            for(int i=0; i<basket_arr.Count; i++)
            {
                MessageBox.Show("productOrder id = " + productOrderID.ToString());
                productOrderID++;

            }
            */
            string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) )";

            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();


                for (int i = 0; i < basket_arr.Count; i++)
                {
                    int productid = int.Parse(basket_arr[i]);
                    int orderQuantity = int.Parse(basket_num_arr[i]);
                    int orderAmount = int.Parse(basket_price_arr[i]);
                    int total = orderQuantity * orderAmount;


                    //MessageBox.Show("productOrder id = " + productOrderID.ToString());
                    string productInsertQuery = $"INSERT INTO PRODUCT_ORDERS (PRODUCT_ORDER_ID, ORDER_ID, PRODUCT_ID, ORDER_QUANTITY, ORDER_AMOUNT, TOTAL) VALUES ({productOrderID}, {orderID}, {productid}, {orderQuantity}, {orderAmount}, {total})";

                    productOrderID++;
                    using (var productInsertCommand = new OracleCommand(productInsertQuery, connection))
                    {
                        int productRowsAffected = productInsertCommand.ExecuteNonQuery();

                        /*
                        if (productRowsAffected > 0)
                        {
                            MessageBox.Show($"주문 {productOrderID}가 완료되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show($"주문 {productOrderID}에 실패했습니다.");
                        }
                        */
                    }
                }
            }
        }

        private void sc_hold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1sa_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) )";

                using (var connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    for (int i = 40025; i < 40027; i++)
                    {
                        string productInsertQuery = $"INSERT INTO PRODUCT_ORDERS (PRODUCT_ORDER_ID, ORDER_ID, PRODUCT_ID, ORDER_QUANTITY, ORDER_AMOUNT, TOTAL) VALUES ({i}, 30031, 10000, 3, 1800, 3600)";

                        using (var productInsertCommand = new OracleCommand(productInsertQuery, connection))
                        {
                            int productRowsAffected = productInsertCommand.ExecuteNonQuery();

                            if (productRowsAffected > 0)
                            {
                                MessageBox.Show($"주문 {i}가 완료되었습니다.");
                            }
                            else
                            {
                                MessageBox.Show($"주문 {i}에 실패했습니다.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
