using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUI.Models;

namespace DBUI.Interface
{
    public class PropertyPanel : Panel
    {
        public bool IsSelected { get; private set; }
        public string InternalName { get; }
        public string Value
        {
            get
            {
                return text.Text;
            }
        }

        private CheckBox check;
        private TextBox text;

        public PropertyPanel(CommonAppObject columnTieback)
        {
            Size = new Size(270, 60);
            IsSelected = false;
            InternalName = columnTieback.InternalName;

            check = new CheckBox
            {
                Name = $"{columnTieback.InternalName}Check",
                Text = columnTieback.FriendlyName,
                AutoSize = true,
                Location = new Point(5, 5)
            };
            check.CheckedChanged += new EventHandler(PropertyPanelCheck_CheckChanged);
            Controls.Add(check);

            text = new TextBox
            {
                Name = $"{columnTieback.InternalName}Textbox",
                Size = new Size(255, 25),
                Location = new Point(5, 30)
            };
            text.GotFocus += new EventHandler(PropertyPanelText_Focused);
            Controls.Add(text);
        }

        public void Reset()
        {
            check.Checked = false;
            text.Text = string.Empty;
        }

        //Event handlers
        private void PropertyPanelCheck_CheckChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                IsSelected = true;
                (sender as CheckBox).BackColor = Color.Yellow;
                BackColor = Color.SkyBlue;
                text.Focus();
            }
            else
            {
                IsSelected = false;
                (sender as CheckBox).BackColor = Color.Transparent;
                BackColor = Color.Transparent;
            }
        }

        private void PropertyPanelText_Focused(object sender, EventArgs e)
        {
            check.Checked = true;
        }
    }
}