using DBUI.Business;
using DBUI.Models;
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
        private ConnectionProfile connection;
        private Entity referenceEntity;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AuthenticationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AuthenticationCheckbox.Checked)
            {
                UsernameTextbox.Text = string.Empty;
                UsernameTextbox.Enabled = false;
                PasswordTextbox.Text = string.Empty;
                PasswordTextbox.Enabled = false;
            }
            else
            {
                UsernameTextbox.Enabled = true;
                PasswordTextbox.Enabled = true;
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            connection = new ConnectionProfile();
            bool validInput = true;
            List<string> errors = new List<string>();

            if (ServerTextbox.Text != string.Empty) connection.Server = ServerTextbox.Text;
            else
            {
                validInput = false;
                errors.Add("server");
            }

            if (DatabaseTextbox.Text != string.Empty) connection.Database = DatabaseTextbox.Text;
            else
            {
                validInput = false;
                errors.Add("database");
            }

            if (TableTextbox.Text != string.Empty) connection.Table = TableTextbox.Text;
            else
            {
                validInput = false;
                errors.Add("table");
            }

            if (AuthenticationCheckbox.Checked) connection.AuthenticationType = "Windows";
            else
            {
                connection.AuthenticationType = "Server";

                if (UsernameTextbox.Text != string.Empty) connection.Username = UsernameTextbox.Text;
                else
                {
                    validInput = false;
                    errors.Add("username");
                }

                if (PasswordTextbox.Text != string.Empty)
                {
                    connection.Password = new SecureString();
                    foreach (char c in PasswordTextbox.Text.ToCharArray())
                    {
                        connection.Password.AppendChar(c);
                    }
                }
                else
                {
                    validInput = false;
                    errors.Add("password");
                }
            }

            if (validInput)
            {
                DbuiManager.Profile = connection;
                if (DbuiManager.TestConnection())
                {
                    referenceEntity = new Entity();
                    referenceEntity.Properties = DbuiManager.GetProperties();

                    SearchPanel.Controls.Clear();
                    foreach (Property p in referenceEntity.Properties)
                    {
                        SearchPanel.Controls.Add(new ReferencePropertyPanel(p));
                    }
                }
                else MessageBox.Show("Can't establish connection", "Alert", MessageBoxButtons.OK);
            }
            else
            {
                string errorString = "The following fields can't be empty: ";
                bool firstError = true;
                foreach (string s in errors)
                {
                    if (firstError)
                    {
                        errorString += $"{s}";
                        firstError = false;
                    }
                    else
                    {
                        errorString += $", {s}";
                    }
                }

                MessageBox.Show(errorString, "Error", MessageBoxButtons.OK);
            }
        }

        private void ClearConnectionButton_Click(object sender, EventArgs e)
        {
            ServerTextbox.Text = string.Empty;
            DatabaseTextbox.Text = string.Empty;
            TableTextbox.Text = string.Empty;

            AuthenticationCheckbox.Checked = true;
            UsernameTextbox.Text = string.Empty;
            PasswordTextbox.Text = string.Empty;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            Entity searchEntity = new Entity();
            searchEntity.Properties = referenceEntity.Properties;
            foreach (ReferencePropertyPanel rp in SearchPanel.Controls)
            {
                if (rp.IsSelected)
                {
                    referenceEntity.Properties[index].Value = rp.Text;
                }
                index++;
            }

            if (DbuiManager.Search(referenceEntity))
            {
                //Data table is pulled out of manager for testing only! An entity object will be returned later on.
                TableForm oForm = new TableForm(DbuiManager.result);
                oForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You did not enter any search terms", "Alert", MessageBoxButtons.OK);
            }
        }

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            foreach (ReferencePropertyPanel rp in SearchPanel.Controls)
            {
                rp.Clear();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}