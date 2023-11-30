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
    public partial class Productform : Form
    {
        DBClass dbc;
        public Productform()
        {
            InitializeComponent();
            dbc = new DBClass();
        }

        private void Productform_Load(object sender, EventArgs e)
        {
            dbc.DB_Open_Product();
            DBGrid_PD.DataSource = dbc.PhoneTable.DefaultView;
        }

        private void Pd_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int maxProductId = 0;

                foreach (DataRow row in dbc.PhoneTable.Rows)
                {
                    int currentId;
                    if (int.TryParse(row["PRODUCT_ID"].ToString(), out currentId))
                    {
                        if (currentId > maxProductId)
                        {
                            maxProductId = currentId;
                        }
                    }
                }

                int newProductId = maxProductId + 1;

                string productName = Pd_name.Text;
                string productPrice = Pd_price.Text;
                string productStock = Pd_stock.Text;


                DataRow newProductRow = dbc.PhoneTable.NewRow();
                newProductRow["PRODUCT_ID"] = newProductId.ToString();
                newProductRow["PRODUCT_NAME"] = productName;
                newProductRow["PRICE"] = productPrice;
                newProductRow["STOCK_QUANTITY"] = productStock;

                dbc.PhoneTable.Rows.Add(newProductRow);

                dbc.DBAdapter.Update(dbc.DS, "product");

                dbc.DB_Open_Product();
                DBGrid_PD.DataSource = dbc.PhoneTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DBGrid_PD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataRowView selectedRow = (DataRowView)DBGrid_PD.Rows[e.RowIndex].DataBoundItem;

                    Pd_name.Text = selectedRow["PRODUCT_NAME"].ToString();
                    Pd_price.Text = selectedRow["PRICE"].ToString();
                    Pd_stock.Text = selectedRow["STOCK_QUANTITY"].ToString();
                    Pd_id.Text = selectedRow["PRODUCT_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void Pd_Del_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(Pd_id.Text))
                {
                    MessageBox.Show("삭제할 제품번호를 입력하세요.");
                    return;
                }

                try
                {

                    // SHOP 테이블에서 해당 제품을 참조하는 레코드를 삭제합니다.
                    DataRow[] shopRows = dbc.PhoneTable.Select($"PRODUCT_ID = {Pd_id.Text}");
                    foreach (DataRow shopRow in shopRows)
                    {
                        shopRow.Delete();
                    }

                    // 변경된 내용을 데이터베이스에 반영합니다.
                    dbc.DBAdapter.Update(dbc.DS, "PRODUCT");

                    // 업데이트된 데이터를 보여주기 위해 재로드하거나 그리드를 새로고침합니다.
                    dbc.DB_Open_Product();
                    DBGrid_PD.DataSource = dbc.PhoneTable.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    }
}
