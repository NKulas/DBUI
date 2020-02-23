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
    public class ReferencePropertyPanel : Panel
    {
        public bool IsSelected { get; set; } = false;
        public string SqlName { get; private set; }
        private CheckBox check;
        private TextBox text;

        public string UserText { get { return text.Text; } }

        public ReferencePropertyPanel(Property tieback)
        {
            Size = new Size(270, 60);
            SqlName = tieback.SqlName;

            check = new CheckBox
            {
                Name = $"{tieback.SqlName}Check",
                Text = tieback.DisplayAlias,
                AutoSize = true,
                Location = new Point(5, 5)
            };
            check.CheckedChanged += new EventHandler(RpChk_CheckChanged);
            Controls.Add(check);

            text = new TextBox
            {
                Name = $"{tieback.SqlName}Textbox",
                Size = new Size(255, 25),
                Location = new Point(5, 30)
            };
            text.GotFocus += new EventHandler(RpTxt_Focused);
            Controls.Add(text);
        }

        public void Clear()
        {
            check.Checked = false;
            text.Text = string.Empty;
        }

        //Event handlers
        private void RpChk_CheckChanged(object sender, EventArgs e)
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

        private void RpTxt_Focused(object sender, EventArgs e)
        {
            check.Checked = true;
        }
    }
}