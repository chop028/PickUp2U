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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Registerform Registerform = new Registerform(); // 이동하고자 하는 폼으로 변경
            Registerform.ShowDialog();
        }
    }
}
