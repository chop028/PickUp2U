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
    public partial class ProgressSettingform : Form
    {
        private static ProgressSettingform instance;
        private int paymentId;
        public static ProgressSettingform GetInstance(int orderId)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProgressSettingform(orderId);
            }
            return instance;
        }
        public ProgressSettingform(int orderId)
        {
            InitializeComponent();
            this.paymentId = GetPaymentIdFromOrderId(orderId); // 주문 ID를 통해 PAYMENTS 테이블의 PAYMENT_ID 가져오기

        }
        public string ExpectedTime { get; private set; }
        public string Status { get; private set; }
        public DateTime ProductInProgressTime { get; private set; }
        public DateTime PickupWaitingTime { get; private set; }
        public DateTime PickupCompleteTime { get; private set; }

        public ProgressSettingform()
        {
            InitializeComponent();
        }

        private void ProgressSettingform_Load(object sender, EventArgs e)
        {

        }
        private int GetPaymentIdFromOrderId(int orderId)
        {
            int paymentId = 0;

            string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)))"; // 오라클 연결 문자열 입력

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT PAYMENT_ID FROM PAYMENTS WHERE ORDER_ID = :orderId";

                OracleCommand command = new OracleCommand(selectQuery, connection);
                command.Parameters.Add(":orderId", OracleDbType.Int32).Value = orderId;

                OracleDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    paymentId = reader.GetInt32(0); // PAYMENT_ID 가져오기
                }

                reader.Close();
            }

            return paymentId;
        }

        private void radProductInProgress_CheckedChanged(object sender, EventArgs e)
        {
            if (radProductInProgress.Checked)
            {
                ProductInProgressTime = DateTime.Now;
                txtInProgressTime.Text = ProductInProgressTime.ToString();
            }
        }

        private void radPickupWaiting_CheckedChanged(object sender, EventArgs e)
        {
            if (radPickupWaiting.Checked)
            {
                PickupWaitingTime = DateTime.Now;
                txtWaitingTime.Text = PickupWaitingTime.ToString();
            }
        }

        private void radPickupComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (radPickupComplete.Checked)
            {
                PickupCompleteTime = DateTime.Now;
                txtCompleteTime.Text = PickupCompleteTime.ToString();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
{
            if (int.TryParse(txtExpectedTime.Text, out int expectedMinutes))
            {
                ExpectedTime = expectedMinutes.ToString();

                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)))"; // 오라클 데이터베이스 연결 문자열을 입력해야 합니다.

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE PICKUP_PROGRESS " +
                                         "SET EXPECTED_TIME = :expectedTime, " +
                                         "START_DATE = :startDate, " +
                                         "END_DATE = :endDate, " +
                                         "PICKUP_DATE = :pickupDate " +
                                         "WHERE PAYMENT_ID = :paymentId";

                    OracleCommand command = new OracleCommand(updateQuery, connection);

                    command.Parameters.Add(":expectedTime", OracleDbType.Int32).Value = expectedMinutes; // EXPECTED_TIME에 입력된 숫자를 저장
                    command.Parameters.Add(":startDate", OracleDbType.TimeStamp).Value = ProductInProgressTime;
                    command.Parameters.Add(":endDate", OracleDbType.TimeStamp).Value = PickupWaitingTime;
                    command.Parameters.Add(":pickupDate", OracleDbType.TimeStamp).Value = PickupCompleteTime;
                    command.Parameters.Add(":paymentId", OracleDbType.Int32).Value = paymentId;

                    command.ExecuteNonQuery();
                }

                // Form1을 숨기고 ProgressForm을 보여줌
                this.Hide();
                // ShopOrderHistoryform으로 돌아가는 코드 추가
                ShopOrderHistoryform shopOrderHistoryform = new ShopOrderHistoryform();
                shopOrderHistoryform.Show();
            }
            else
            {
                MessageBox.Show("올바른 시간 형식을 입력하세요."); // 유효하지 않은 값에 대한 메시지 출력
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private string GetSelectedStatus()
        {
            if (radProductInProgress.Checked)
            {
                return "상품 준비중";
            }
            else if (radPickupWaiting.Checked)
            {
                return "픽업 대기중";
            }
            else if (radPickupComplete.Checked)
            {
                return "픽업 완료";
            }
            else
            {
                return string.Empty;
            }
        }

        private void txtExpectedTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
