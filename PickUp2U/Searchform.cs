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

        int USER_ID = 1;
        
        public Searchform()
        {
            InitializeComponent();
            dbSc = new SearchDBClass();

            dbSc.DB_Open();

            DataView dv = dbSc.PhoneTable.DefaultView;
            dv.RowFilter = "PRODUCT_STATUS = 0";

            sc_list.DataSource = dv;

            USERID.Text = USER_ID.ToString();
        }
        private void sc_Pdlist_Click(object sender, EventArgs e)
        {
        }

        private void sc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = sc_item.Text;

                SearchDB2Class searchDB = new SearchDB2Class();

                searchDB.DB_Open();

                DataView dv = searchDB.PhoneTable.DefaultView;
                dv.RowFilter = $"PRODUCT_NAME = '{itemName}'";

                //sc_hold.DataSource = dv;

                string productId = string.Empty;
                if (dv.Count > 0)
                {
                    productId = dv[0]["PRODUCT_ID"].ToString();

                    DataView shopView = new DataView(searchDB.ShopTable);
                    shopView.RowFilter = $"PRODUCT_ID = '{productId}'";

                    sc_hold.DataSource = shopView;
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
                        object productOrderIdResult = maxProductOrderIdCommand.ExecuteScalar();
                        int productOrderId = 40000;

                        if (productOrderIdResult != DBNull.Value)
                        {
                            productOrderId = Convert.ToInt32(productOrderIdResult) + 1;
                        }

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

                            string insertQuery = $"INSERT INTO ORDERS (ORDER_ID, USER_ID, SHOP_ID, ORDER_TIME) VALUES ({newOrderId}, '{USER_ID}', 20000, TO_TIMESTAMP('{formattedDate}', 'YYYY-MM-DD HH24:MI:SS'))";

                            using (var insertCommand = new OracleCommand(insertQuery, connection))
                            {
                                int rowsAffected = insertCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    int productId = 10000;
                                    int orderQuantity = 3;
                                    int orderAmount = 1800;
                                    int total = 5400;

                                    string productInsertQuery = $"INSERT INTO PRODUCT_ORDERS (PRODUCT_ORDER_ID, ORDER_ID, PRODUCT_ID, ORDER_QUANTITY, ORDER_AMOUNT, TOTAL) VALUES ({productOrderId}, {newOrderId}, {productId}, {orderQuantity}, {orderAmount}, {total})";

                                    using (var productInsertCommand = new OracleCommand(productInsertQuery, connection))
                                    {
                                        int productRowsAffected = productInsertCommand.ExecuteNonQuery();

                                        if (productRowsAffected > 0)
                                        {
                                            MessageBox.Show("제품 주문이 완료되었습니다.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("제품 주문에 실패했습니다.");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("주문에 실패했습니다.");
                                }
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
