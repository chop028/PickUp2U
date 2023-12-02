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
        public MainOwnerform()
        {
            InitializeComponent();

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
    }
}
