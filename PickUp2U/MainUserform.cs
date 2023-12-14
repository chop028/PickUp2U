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
    public partial class MainUserform : Form
    {

        public static int userId;
        public MainUserform(int userId)
        {
            InitializeComponent();
            MainUserform.userId = userId;
            txt_userid.Text = userId.ToString();
        }

        Searchform search;

        private void 주문하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchform.userId = userId;
            search = new Searchform(); //Form2
            search.MdiParent = this;
            search.Show();  //Mdi폼의 자식은 Show()모달리스만 사용 가능
        }

        private void 주문내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetailform orderDetail = new OrderDetailform(userId);
            orderDetail.userId = userId; // userId가 OrderDetailform의 속성이라고 가정합니다. 필요에 따라 조절하세요.
            orderDetail.WindowState = FormWindowState.Maximized;
            orderDetail.MdiParent = this;
            orderDetail.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginform loginForm = new Loginform();
            loginForm.Show();
        }

        private void 픽업정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserOrderHistoryform userOrderHistoryform = new UserOrderHistoryform();
            userOrderHistoryform.Show();
        }
    }
}
