using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.Interface
{
    public class FlowGroupbox : GroupBox
    {
        public FlowGroupbox() : base()
        {
            ControlAdded += new ControlEventHandler(FlowGbx_ControlAdded);
            ControlRemoved += new ControlEventHandler(FlowGbx_ControlRemoved);

            panel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            Controls.Add(panel);

            nextX = Spacing;
            nextY = Spacing;
        }

        public int Spacing { get; set; } = 5;
        public ControlCollection ControlList { get
            {
                return panel.Controls;
            } 
        }

        private int nextX;
        private int nextY;
        private Panel panel;

        public void AddControl(Control control)
        {
            control.Location = new System.Drawing.Point(nextX, nextY);
            panel.Controls.Add(control);

            nextY += (control.Height + 5);
        }

        public void ClearControls()
        {
            panel.Controls.Clear();
            nextX = Spacing;
            nextY = Spacing;
        }

        private static void FlowGbx_ControlAdded(object sender, EventArgs e)
        {
            
        }

        private static void FlowGbx_ControlRemoved(object sender, EventArgs e)
        {

        }
    }
}