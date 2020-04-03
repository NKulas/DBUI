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
    public partial class FlowGroupbox : GroupBox
    {
        public int Spacing { get; private set; }
        public ControlCollection ControlList
        {
            get
            {
                return panel.Controls;
            }
        }

        private int nextX;
        private int nextY;
        private Panel panel;

        public FlowGroupbox() : base()
        {
            InitializeComponent();

            Spacing = 5;
            Prepare();
        }

        public FlowGroupbox(int spacing) : base()
        {
            InitializeComponent();

            Spacing = spacing;
            Prepare();
        }

        private void Prepare()
        {
            panel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            Controls.Add(panel);

            nextX = Spacing;
            nextY = Spacing;
        }

        public void AddControl(Control control)
        {
            control.Location = new System.Drawing.Point(nextX, nextY);
            panel.Controls.Add(control);

            nextY += control.Height + 5;
        }

        public void RemoveControl(int index)
        {
            Control c = panel.Controls[index];
            RemoveControl(c);
        }

        public void RemoveControl(Control control)
        {
            panel.Controls.Remove(control);

            nextY = Spacing;

            foreach (Control c in panel.Controls)
            {
                c.Location = new System.Drawing.Point(nextX, nextY);
                nextY += control.Height + 5;
            }
        }

        public void ClearControls()
        {
            panel.Controls.Clear();
            nextX = Spacing;
            nextY = Spacing;
        }
    }

}