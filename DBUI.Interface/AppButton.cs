using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.Interface
{
    public class AppButton : Button
    {
        public AppButton() : base()
        {
            MouseEnter += new EventHandler(AppBtn_MouseEnter);
            MouseLeave += new EventHandler(AppBtn_MouseLeave);
            /*MouseDown += new MouseEventHandler(AppBtn_MouseDown);
            MouseUp += new MouseEventHandler(AppBtn_MouseUp);*/
        }

        public static void AppBtn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.SteelBlue;
            (sender as Button).ForeColor = Color.White;
        }

        public static void AppBtn_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
            (sender as Button).ForeColor = Color.Black;
        }

        /*public static void AppBtn_MouseDown(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.SkyBlue;
        }

        public static void AppBtn_MouseUp(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.SteelBlue;
        }*/
    }
}