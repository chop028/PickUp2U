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

namespace PickUp2U
{
    public partial class Progressform : Form
    {
        private string ExpectedTime;
        private string Status;
        private DateTime ProductInProgressTime;
        private DateTime PickupWaitingTime;
        private DateTime PickupCompleteTime;
        public Progressform(string expectedTime, string status, DateTime inProgressTime, DateTime waitingTime, DateTime completeTime)
        {
            InitializeComponent();
            ExpectedTime = expectedTime; // 예상 준비시간
            Status = status; // 상태 정보
            ProductInProgressTime = inProgressTime; // 상품 준비중 시간
            PickupWaitingTime = waitingTime; // 픽업 대기중 시간
            PickupCompleteTime = completeTime; // 픽업 완료 시간
            InitializeUI(); // 사용자 인터페이스 초기화

        }

        private void InitializeUI()
        {
            // 1. 남은 시간을 표시하는 Label 추가
            timer1.Interval = 1000; // 1초마다 갱신
            timer1.Tick += timer1_Tick;
            timer1.Start();

            // 2. RadioButton의 상태에 따라 상태 정보를 받아와 Progress Bar를 설정
            SetProgressBar();

            // 3. 각 상태별 시간을 보여주는 Label 추가
            lblInProgressTime.Text = ProductInProgressTime != DateTime.MinValue ? "상품준비: " + ProductInProgressTime.ToString() : "상품준비: ";
            lblWaitingTime.Text = PickupWaitingTime != DateTime.MinValue ? "픽업대기: " + PickupWaitingTime.ToString() : "픽업대기: ";
            lblCompleteTime.Text = PickupCompleteTime != DateTime.MinValue ? "픽업완료: " + PickupCompleteTime.ToString() : "픽업완료: ";
        }




        private void SetProgressBar()
        {
            // RadioButton의 상태에 따라 Progress Bar 설정
            switch (Status)
            {
                case "상품 준비중":
                    progressBar.Value = 33;
                    break;
                case "픽업 대기중":
                    progressBar.Value = 66;
                    break;
                case "픽업 완료":
                    progressBar.Value = 100;
                    break;
                default:
                    progressBar.Value = 0;
                    break;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ExpectedTime))
            {
                DateTime expectedDateTime;
                if (DateTime.TryParseExact(ExpectedTime, "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None, out expectedDateTime))
                {
                    if (expectedDateTime > DateTime.Now)
                    {
                        TimeSpan remainingTime = expectedDateTime - DateTime.Now;

                        // 남은 시간을 분 단위로 계산하여 출력 (소수점 자리 제거)
                        int remainingMinutes = (int)Math.Round(remainingTime.TotalMinutes);
                        lblRemainingTime.Text = $"남은시간: 약 {remainingMinutes} 분";

                    }
                    else
                    {
                        lblRemainingTime.Text = "Time's up!";
                        timer1.Stop(); // 타이머 정지
                    }
                }
                else
                {
                    // 유효한 DateTime으로 변환할 수 없는 경우에 대한 처리
                    lblRemainingTime.Text = "Invalid DateTime";
                    timer1.Stop(); // 타이머 정지
                }
            }
        }
    }
}