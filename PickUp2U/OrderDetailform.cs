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
        string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
        public OrderDetailform()
        {
            InitializeComponent();
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
                    INNER JOIN PRODUCTS P ON PO.PRODUCT_ID = P.PRODUCT_ID";

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
    }
}