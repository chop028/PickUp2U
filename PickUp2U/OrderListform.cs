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
    public partial class OrderListform : Form
    {
        public OrderListform()
        {
            InitializeComponent();
            // 초기에 BtnPickupReady 및 BtnPickupFin 버튼을 숨김
            BtnPickupReady.Visible = false;
            BtnPickupFin.Visible = false;
        }

        private void BtnOrderReady_Click(object sender, EventArgs e)
        {
            // BtnOrderReady를 클릭하면 BtnOrderReady와 BtnPickupFin을 숨기고 BtnPickupReady를 보이게 함
            BtnOrderReady.Visible = false;
            BtnPickupFin.Visible = false;
            BtnPickupReady.Visible = true;
        }

        private void BtnPickupReady_Click(object sender, EventArgs e)
        {
            // BtnPickupReady를 클릭하면 BtnPickupReady와 BtnOrderReady를 숨기고 BtnPickupFin을 보이게 함
            BtnPickupReady.Visible = false;
            BtnOrderReady.Visible = false;
            BtnPickupFin.Visible = true;
        }

        private void BtnPickupFin_Click(object sender, EventArgs e)
        {
            // BtnPickupFin을 클릭하면 모든 버튼을 다시 보이게 함
            BtnOrderReady.Visible = true;
            BtnPickupReady.Visible = true;
            BtnPickupFin.Visible = true;
        }
    }
}
