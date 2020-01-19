using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DBUI.Business
{
    public static class SharedResources
    {
        public static void btn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.SteelBlue;
            (sender as Button).ForeColor = Color.White;
        }

        public static void btn_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
            (sender as Button).ForeColor = Color.Black;
        }

        public enum eAuthenticationTypes
        {
            Windows,
            Server
        }
    }
}
