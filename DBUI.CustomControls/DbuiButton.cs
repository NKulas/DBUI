using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.CustomControls
{
    public partial class DbuiButton : Button
    {
        public DbuiButton() : base()
        {
            InitializeComponent();

            MouseEnter += new EventHandler(DbuiButton_MouseEnter);
            MouseLeave += new EventHandler(DbuiButton_MouseLeave);
        }

        private static void DbuiButton_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.SteelBlue;
            (sender as Button).ForeColor = Color.White;
        }

        private static void DbuiButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
            (sender as Button).ForeColor = Color.Black;
        }

    }
}