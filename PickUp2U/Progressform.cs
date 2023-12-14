using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace PickUp2U
{
    public partial class Progressform : Form
    {
        private int paymentId;
        private int expectedTimeInMinutes; // 분 단위의 예상 시간을 저장하는 변수
        private int expectedTimeInSeconds;
        private Timer updateTimer; // System.Windows.Forms.Timer 타이머 선언
        private DateTime endDate;
        public static Progressform GetInstance(int selectedOrderId)
        {
            Progressform progressform = new Progressform(selectedOrderId);
            return progressform;
        }

        private Progressform(int selectedOrderId)
        {
            InitializeComponent();
            GetProgressInformation(selectedOrderId);
            StartTimer();
        }

        private void StartTimer()
        {
            updateTimer = new Timer();
            updateTimer.Interval = 1000; // 1초마다 업데이트
            updateTimer.Tick += new EventHandler(timer_Tick);
            updateTimer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (expectedTimeInMinutes > 0)
            {
                expectedTimeInSeconds--;
                UpdateRemainingTime();
            }
            else
            {
                updateTimer.Stop(); // 시간이 0이 되면 타이머 중지
                lblRemainingTime.Text = "00:00";
            }
        }

        private void GetProgressInformation(int selectedOrderId)
        {
            string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)))";

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = $"SELECT PICKUP_PROGRESS.EXPECTED_TIME, PICKUP_PROGRESS.START_DATE, PICKUP_PROGRESS.END_DATE, PICKUP_PROGRESS.PICKUP_DATE, " +
                                 $"SHOPS.SHOP_NAME, SHOPS.SHOP_LOCATION " +
                                 $"FROM PICKUP_PROGRESS " +
                                 $"INNER JOIN PAYMENTS ON PICKUP_PROGRESS.PAYMENT_ID = PAYMENTS.PAYMENT_ID " +
                                 $"INNER JOIN ORDERS ON PAYMENTS.ORDER_ID = ORDERS.ORDER_ID " +
                                 $"INNER JOIN SHOPS ON ORDERS.SHOP_ID = SHOPS.SHOP_ID " +
                                 $"WHERE ORDERS.ORDER_ID = {selectedOrderId}";

                    OracleCommand command = new OracleCommand(selectQuery, connection);
                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        expectedTimeInMinutes = Convert.ToInt32(reader["EXPECTED_TIME"]); // DB에서 가져온 분 단위의 값

                        // START_DATE 값이 NULL인 경우 처리
                        object start_date = reader["START_DATE"];
                        if (start_date == DBNull.Value || Convert.ToDateTime(start_date) == DateTime.MinValue)
                        {
                            lblInProgressTime.Text = "상품준비: "; // 혹은 원하는 디폴트 텍스트 설정
                        }
                        else
                        {
                            lblInProgressTime.Text = "상품준비: " + Convert.ToDateTime(start_date).ToString();
                        }
                        // END_DATE 값이 NULL이거나 0001-01-01 00:00:00인 경우 처리
                        object end_date = reader["END_DATE"];
                        if (end_date == DBNull.Value || Convert.ToDateTime(end_date) == DateTime.MinValue)
                        {
                            lblWaitingTime.Text = "준비완료: "; // 혹은 원하는 디폴트 텍스트 설정
                        }
                        else
                        {
                            lblWaitingTime.Text = "준비완료: " + Convert.ToDateTime(end_date).ToString();
                        }
                        // PICKUP_DATE 값이 NULL이거나 0001-01-01 00:00:00인 경우 처리
                        object pickup_date = reader["PICKUP_DATE"];
                        if (pickup_date == DBNull.Value || Convert.ToDateTime(pickup_date) == DateTime.MinValue)
                        {
                            lblCompleteTime.Text = "픽업완료: "; // 혹은 원하는 디폴트 텍스트 설정
                        }
                        else
                        {
                            lblCompleteTime.Text = "픽업완료: " + Convert.ToDateTime(pickup_date).ToString();
                        }
                        string shopName = Convert.ToString(reader["SHOP_NAME"]);
                        string shopLocation = Convert.ToString(reader["SHOP_LOCATION"]);

                        shoplable.Text = $"매장명: {shopName}";
                        locationlable.Text = $"매장위치: {shopLocation}";

                        // 현재 시간을 가져옵니다.
                        DateTime currentTime = DateTime.Now;

                        // START_DATE부터 현재 시간까지의 차이를 계산하여 초 단위로 설정합니다.
                        DateTime startDate = Convert.ToDateTime(reader["START_DATE"]);
                        TimeSpan timeDifference = currentTime - startDate;
                        expectedTimeInSeconds = expectedTimeInMinutes * 60 - (int)timeDifference.TotalSeconds;
                        endDate = (reader["END_DATE"] != DBNull.Value) ? Convert.ToDateTime(reader["END_DATE"]) : DateTime.MinValue;
                        // 타이머 시작
                        StartTimer();

                        

                       

                        // 나머지 코드는 변경되지 않았습니다.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터를 가져오는 중 오류가 발생했습니다: " + ex.Message);
            }
        }
        private void UpdateProgressBar()
        {
            if (endDate != DateTime.MinValue)
            {
                progressBar.Value = 100;
                return;
            }

            int totalTime = expectedTimeInMinutes * 60;
            int remainingTime = expectedTimeInSeconds;

            if (remainingTime <= 0)
            {
                progressBar.Value = 100;
                return;
            }

            // 역으로 계산하여 ProgressBar 값을 조정합니다.
            double ratio = 1.0 - ((double)remainingTime / totalTime);
            int progressValue = (int)(ratio * 100);

            progressBar.Value = progressValue;
        }



private void UpdateRemainingTime()
{
    // PICKUP_DATE 값이 NULL이거나 0001-01-01 00:00:00인 경우
    if (endDate != DateTime.MinValue)
    {
        lblRemainingTime.Text = "남은시간: 0분";
        UpdateProgressBar();
        return;
    }

    int remainingMinutes = expectedTimeInSeconds / 60; // 초를 분 단위로 변환
    if (remainingMinutes < 0)
    {
        remainingMinutes = 0; // 음수일 경우 0으로 설정
    }

    lblRemainingTime.Text = "남은시간: " + remainingMinutes.ToString() + "분";
    UpdateProgressBar();
}

        private void Progressform_Load(object sender, EventArgs e)
        {

        }
    }
}
