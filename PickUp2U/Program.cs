using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickUp2U
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new ShopOrderHistoryform());
=======
            Application.Run(new OrderListform());
>>>>>>> a7148f9b4085a33afe6e7cd5e4f7c13827f604cf
        }
    }
}
