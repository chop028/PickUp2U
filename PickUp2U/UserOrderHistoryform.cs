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
    public partial class UserOrderHistoryform : Form
    {
        public UserOrderHistoryform()
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

                    dataGridViewUserHistory.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // 예외 처리 - 메시지 박스 등을 통해 사용자에게 오류를 알릴 수 있습니다.
                MessageBox.Show("데이터를 가져오는 중 오류가 발생했습니다: " + ex.Message);
            }
        }

        private void dataGridViewUserHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUserHistory.Rows[e.RowIndex];
                int selectedOrderId = Convert.ToInt32(row.Cells["ORDER_ID"].Value);

                // ProgressSettingform이 이미 열려있는 경우 기존 인스턴스를 사용하고, 아닌 경우 새로운 인스턴스를 생성합니다.
                Progressform progressForm = Progressform.GetInstance(selectedOrderId);

                if (progressForm.Visible)
                {
                    progressForm.BringToFront();
                }
                else
                {
                    progressForm.Show();
                }
            }
        }
    }
}
