using DBUI.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.Interface
{
    public partial class MainForm : Form
    {
        private ReferenceEntity re;
        public MainForm()
        {
            InitializeComponent();
            re = new ReferenceEntity();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            List<string> invalidFields = new List<string>();
            if (string.IsNullOrEmpty(ServerTextbox.Text))
            {
                invalidFields.Add("server");
            }
            if (string.IsNullOrEmpty(DatabaseTextbox.Text))
            {
                invalidFields.Add("database");
            }
            if (string.IsNullOrWhiteSpace(TableTextbox.Text))
            {
                invalidFields.Add("table");
            }

            if (!AuthenticationCheckbox.Checked && string.IsNullOrEmpty(UsernameTextbox.Text))
            {
                invalidFields.Add("username");
            }
            if (!AuthenticationCheckbox.Checked && string.IsNullOrEmpty(PasswordTextbox.Text))
            {
                invalidFields.Add("password");
            }

            if (invalidFields.Count == 0)
            {
                ServerInteraction.Server = ServerTextbox.Text;
                ServerInteraction.Database = DatabaseTextbox.Text;
                ServerInteraction.Table = TableTextbox.Text;

                if (AuthenticationCheckbox.Checked)
                {
                    ServerInteraction.AuthenticationType = SharedResources.eAuthenticationTypes.Windows;
                }
                else
                {
                    ServerInteraction.AuthenticationType = SharedResources.eAuthenticationTypes.Server;
                    ServerInteraction.Username = UsernameTextbox.Text;
                    SecureString secure = new SecureString();
                    foreach (char c in PasswordTextbox.Text)
                    {
                        secure.AppendChar(c);
                    }
                    ServerInteraction.Password = secure;
                }

                re.LoadReferenceProperties();
                SearchPanel.Controls.AddRange(re.ReferenceProperties.ToArray());
            }
            else
            {
                string message = "The following fields must have a value:\n";

                int counter = 1;
                foreach (string field in invalidFields)
                {
                    message += field;

                    if (counter < invalidFields.Count)
                    {
                        message += ", ";
                    }

                    counter++;
                }

                MessageBox.Show(message, "Can't connect", MessageBoxButtons.OK);
            }
        }

        private void AuthenticationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AuthenticationCheckbox.Checked)
            {
                UsernameTextbox.Enabled = false;
                PasswordTextbox.Enabled = false;
            }
            else
            {
                UsernameTextbox.Enabled = true;
                PasswordTextbox.Enabled = true;
            }
        }

        private void ConnectClearButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in ConnectionPanel.Controls)
            {
                if (c is TextBox) (c as TextBox).Text = string.Empty;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            EntityCollection entities = new EntityCollection();
            string command;
            if (re.GetSqlCommandString(out command))
            {
                entities.DoSearchQuery(command, re.GetSqlParameters());
                TableForm t = new TableForm(entities.dataResult);
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK);
            }
        }

        private void SearchClearButton_Click(object sender, EventArgs e)
        {
            foreach (ReferenceProperty rp in SearchPanel.Controls) {
                rp.Clear();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}