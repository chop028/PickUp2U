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
    public partial class ShopOrderHistoryform : Form
    {
        private bool formHidden = false;

        public ShopOrderHistoryform()
        {
            InitializeComponent();
            DisplayOrderHistory();
        }

        private void DisplayOrderHistory()
        {
            string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)))";

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT PAYMENTS.ORDER_ID, START_DATE, END_DATE, PICKUP_DATE FROM PICKUP_PROGRESS INNER JOIN PAYMENTS ON PICKUP_PROGRESS.PAYMENT_ID = PAYMENTS.PAYMENT_ID";

                    OracleDataAdapter adapter = new OracleDataAdapter(selectQuery, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewOrderHistory.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // 예외 처리 - 메시지 박스 등을 통해 사용자에게 오류를 알릴 수 있습니다.
                MessageBox.Show("데이터를 가져오는 중 오류가 발생했습니다: " + ex.Message);
            }
        }
   

        private void dataGridViewOrderHistory_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOrderHistory.Rows[e.RowIndex];
                int selectedOrderId = Convert.ToInt32(row.Cells["ORDER_ID"].Value);

                // ProgressSettingform이 이미 열려있는 경우 기존 인스턴스를 사용하고, 아닌 경우 새로운 인스턴스를 생성합니다.
                ProgressSettingform progressSettingForm = ProgressSettingform.GetInstance(selectedOrderId);

                if (progressSettingForm.Visible)
                {
                    progressSettingForm.BringToFront();
                }
                else
                {
                    progressSettingForm.Show();
                }
            }
        }

        private void ProgressSettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ProgressSettingform이 닫히면 현재의 폼을 숨깁니다.
            this.Show();
        }
    }
}