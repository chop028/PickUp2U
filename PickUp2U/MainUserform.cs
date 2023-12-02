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
        public MainUserform()
        {
            InitializeComponent();

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
    }
}
