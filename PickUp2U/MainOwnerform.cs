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
    public partial class MainOwnerform : Form
    {

        public static int userId;
        public MainOwnerform(int userId)
        {
            InitializeComponent();
            MainOwnerform.userId = userId;
            txt_userid.Text = userId.ToString();
        }

        private void 매장등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            shop = new Shopform();
            shop.MdiParent = this;
            shop.Show();
        }

        Shopform shop;
        Productform product;

        private void 상품등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            product = new Productform();
            product.MdiParent = this;
            product .Show();  
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginform loginForm = new Loginform();
            loginForm.Show();
        }

        OwnerShopform OwnerShop;

        private void 보유매장조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OwnerShop = new OwnerShopform();
            OwnerShop.MdiParent = this;
            OwnerShop.Show();
        }

<<<<<<< HEAD
        private void 픽업관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ShopOrderHistoryform shopOrderHistoryform = new ShopOrderHistoryform();
            shopOrderHistoryform.Show();
        }

        private void 상품조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 주문조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            OrderListform orderListform = new OrderListform();
            orderListform.Show();
=======
        private void 주문조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {

>>>>>>> a7148f9b4085a33afe6e7cd5e4f7c13827f604cf
        }
    }
}
