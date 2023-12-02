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
                // 분 단위로 변환된 값으로 DateTime을 계산
                DateTime expectedDateTime = DateTime.Now.AddMinutes(expectedMinutes);

                ExpectedTime = expectedDateTime.ToString("yyyyMMddHHmmss");
                Progressform progressForm = new Progressform(
                    ExpectedTime,
                    GetSelectedStatus(),
                    ProductInProgressTime,
                    PickupWaitingTime,
                    PickupCompleteTime
                );

                // Form1을 숨기고 ProgressForm을 보여줌
                this.Hide();
                progressForm.Show();
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
<<<<<<< HEAD
}
=======
}
>>>>>>> fa079993f9f169452dd890ef889c8ccfbc7b9512
