using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace DBUI.Business
{
    public class ReferenceProperty : Panel
    {
        private string displayAlias;
        private CheckBox check;
        private TextBox text;

        public bool IsSelected { get; private set; }
        public string ColumnName { get; private set; }
        public string SqlCommand { get; private set; }

        public ReferenceProperty(string alias, string columnName, string sql)
        {
            displayAlias = alias;
            ColumnName = columnName;
            SqlCommand = sql;

            Size = new Size(270, 60);

            check = new CheckBox
            {
                Name = $"{ColumnName}Check",
                Text = displayAlias,
                AutoSize = true,
                Location = new Point(5, 5)
            };
            check.CheckedChanged += new EventHandler(chk_CheckChanged);
            Controls.Add(check);

            text = new TextBox
            {
                Name = $"{ColumnName}Textbox",
                Size = new Size(255, 25),
                Location = new Point(5, 30)
            };
            text.GotFocus += new EventHandler(txt_Focused);
            Controls.Add(text);
        }

        public void Clear()
        {
            check.Checked = false;
            text.Text = string.Empty;
        }

        public SqlParameter GetParameter()
        {
            return new SqlParameter(ColumnName, text.Text);
        }

        //Event handlers
        private void chk_CheckChanged(object sender, EventArgs e)
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

        private void txt_Focused(object sender, EventArgs e)
        {
            check.Checked = true;
        }
    }
}