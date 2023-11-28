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
        public Searchform()
        {
            InitializeComponent();
            dbSc = new SearchDBClass();
        }
        private void sc_Pdlist_Click(object sender, EventArgs e)
        {
            try
            {
                dbSc.DB_Open();
                sc_list.DataSource = dbSc.PhoneTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = sc_item.Text;

                // SearchDB2Class의 인스턴스 생성
                SearchDB2Class searchDB = new SearchDB2Class();

                // SearchDB2Class의 DB_Open 메서드 호출
                searchDB.DB_Open();

                DataView dv = searchDB.PhoneTable.DefaultView;
                dv.RowFilter = $"PRODUCT_NAME = '{itemName}'";

                //sc_hold.DataSource = dv;

                string productId = string.Empty;
                if (dv.Count > 0)
                {
                    productId = dv[0]["PRODUCT_ID"].ToString();

                    // SearchDB2Class의 ShopTable을 이용하여 필터링
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

        private void sc_hold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 클릭한 셀의 행 인덱스를 가져옵니다.
                int rowIndex = e.RowIndex;

                // 만약 유효한 행이라면
                if (rowIndex >= 0 && rowIndex < sc_hold.Rows.Count)
                {
                    // 클릭한 행에서 PRODUCT_ID 값을 가져옵니다.
                    string productId = sc_hold.Rows[rowIndex].Cells["PRODUCT_ID"].Value.ToString();

                    // sc_Productid 텍스트 박스에 PRODUCT_ID 값을 할당합니다.
                    sc_Productid.Text = productId;
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
                // 클릭한 셀의 행 인덱스를 가져옵니다.
                int rowIndex = e.RowIndex;

                // 만약 유효한 행이라면
                if (rowIndex >= 0 && rowIndex < sc_list.Rows.Count)
                {
                    // 클릭한 행에서 PRODUCT_ID 값을 가져옵니다.
                    string productId = sc_list.Rows[rowIndex].Cells["PRODUCT_ID"].Value.ToString();

                    // sc_Productid 텍스트 박스에 PRODUCT_ID 값을 할당합니다.
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

                    // 새 제품 추가 시에는 가격 배열에 해당하는 제품의 가격을 가져와 저장합니다.
                    SearchDB2Class searchDB = new SearchDB2Class();
                    searchDB.DB_Open();

                    DataView productView = new DataView(searchDB.PhoneTable);
                    productView.RowFilter = $"CONVERT(PRODUCT_ID, 'System.String') = '{productId}'";

                    if (productView.Count > 0)
                    {
                        // 제품 가격을 가져와서 수량과 곱한 값을 basket_price_arr에 추가합니다.
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
                        // basket_price_arr에 있는 모든 숫자 더하기
                        for (int j = 0; j < basket_arr.Count; j++)
                        {
                            int pPrice = int.Parse(basket_price_arr[j]);
                            int pquantity = int.Parse(basket_num_arr[j]);

                            totalPriceC += pPrice * pquantity;
                        }

                        // 합계를 sc_total에 표시
                        sc_total.Text = "총 금액 :" + totalPriceC.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sc_clear_Click(object sender, EventArgs e)
        {
            try
            {
                basket_arr.Clear();
                basket_num_arr.Clear();
                sc_basket.Items.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sc_clear_Click1(object sender, EventArgs e)
        {
            try
            {

                foreach (string price in basket_price_arr)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(basket_price_arr.ToArray());
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
    }
}
