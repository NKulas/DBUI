using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.Business
{
    public class AppButton : Button
    {
        public AppButton()
        {
            MouseEnter += new EventHandler(SharedResources.btn_MouseEnter);
            MouseLeave += new EventHandler(SharedResources.btn_MouseLeave);
        }
    }
}