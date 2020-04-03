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
        private ConnectionProfile connectionData = new ConnectionProfile();
        private CommonAppObject referenceObject = new CommonAppObject(CommonAppObjectType.Server);

        public MainForm()
        {
            InitializeComponent();

            DatabaseTextbox.DisplayMember = "InternalName";
            DbuiManager.Profile = connectionData;

            foreach (Control control in DatabasePanel.Controls)
            {
                control.Enabled = false;
            }
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

            connectionData.Server = ServerTextbox.Text;
        }

        private void ServerConnectionButton_Click(object sender, EventArgs e)
        {
            bool validInput = true;
            List<string> errors = new List<string>();

            if (ServerTextbox.Text == string.Empty)
            {
                validInput = false;
                errors.Add("server");
            }
            else
            {
                connectionData.Server = ServerTextbox.Text;
            }

            if (!AuthenticationCheckbox.Checked)
            {
                connectionData.AuthenticationType = AuthenticationType.Server;

                if (UsernameTextbox.Text == string.Empty)
                {
                    validInput = false;
                    errors.Add("username");
                }
                else
                {
                    connectionData.Username = UsernameTextbox.Text;
                }

                if (PasswordTextbox.Text == string.Empty)
                {
                    validInput = false;
                    errors.Add("password");
                }
                else
                {
                    connectionData.Password = PasswordTextbox.Text;
                }
            }
            else
            {
                connectionData.AuthenticationType = AuthenticationType.Windows;
            }

            if (validInput)
            {
                if (DbuiManager.TestConnection())
                {
                    foreach (Control c in DatabasePanel.Controls)
                    {
                        c.Enabled = true;
                    }
                }
                else
                {
                    new MessageForm("Error", "Can't connect to the specified server. Either it can't be found or your credentials are incorrect.").ShowDialog();
                }
            }
            else
            {
                string errorMessage = "The following fields can't be empty: ";
                bool firstError = true;

                foreach (string error in errors)
                {
                    if (!firstError)
                    {
                        errorMessage += ", ";
                    }
                    else
                    {
                        firstError = false;
                    }

                    errorMessage += error;
                }

                new MessageForm("Error", errorMessage).ShowDialog();
            }
        }

        private void DatabaseTextbox_DropDown(object sender, EventArgs e)
        {
            try
            {
                referenceObject.InternalName = ServerTextbox.Text;

                referenceObject.Children.Clear();
                DbuiManager.UpdateChildren(referenceObject);

                DatabaseTextbox.DataSource = null;
                DatabaseTextbox.DataSource = referenceObject.Children;
                DatabaseTextbox.DisplayMember = "InternalName";
            }
            catch (Exception ex)
            {
                new MessageForm("Error", ex.Message).ShowDialog();
            }
        }

        private void SchemaTextbox_DropDown(object sender, EventArgs e)
        {
            if (DatabaseTextbox.SelectedItem != null)
            {
                connectionData.Database = DatabaseTextbox.Text;

                try
                {
                    (DatabaseTextbox.SelectedItem as CommonAppObject).Children.Clear();
                    DbuiManager.UpdateChildren(DatabaseTextbox.SelectedItem as CommonAppObject);
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message).ShowDialog();
                }

                SchemaTextbox.DataSource = null;
                SchemaTextbox.DataSource = (DatabaseTextbox.SelectedItem as CommonAppObject).Children;
                SchemaTextbox.DisplayMember = "InternalName";
            }
            else
            {
                SchemaTextbox.DataSource = new List<CommonAppObject>();
            }
        }

        private void TableTextbox_DropDown(object sender, EventArgs e)
        {
            if (SchemaTextbox.SelectedItem != null)
            {
                connectionData.Schema = SchemaTextbox.Text;

                try
                {
                    (SchemaTextbox.SelectedItem as CommonAppObject).Children.Clear();
                    DbuiManager.UpdateChildren(SchemaTextbox.SelectedItem as CommonAppObject);
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message).ShowDialog();
                }

                TableTextbox.DataSource = null;
                TableTextbox.DataSource = (SchemaTextbox.SelectedItem as CommonAppObject).Children;
                TableTextbox.DisplayMember = "InternalName";
            }
            else
            {
                SchemaTextbox.DataSource = new List<CommonAppObject>();
            }
        }

        private void DatabaseConnectButton_Click(object sender, EventArgs e)
        {
            bool validInput = true;
            List<string> errors = new List<string>();

            if (DatabaseTextbox.Text == string.Empty)
            {
                validInput = false;
                errors.Add("database");
            }
            else
            {
                connectionData.Database = DatabaseTextbox.Text;
            }

            if (SchemaTextbox.Text == string.Empty)
            {
                validInput = false;
                errors.Add("schema");
            }
            else
            {
                connectionData.Schema = SchemaTextbox.Text;
            }

            if (TableTextbox.Text == string.Empty)
            {
                validInput = false;
                errors.Add("table");
            }
            else
            {
                connectionData.Table = TableTextbox.Text;
            }

            if (validInput)
            {
                SearchPanel.ClearControls();

                try
                {
                    connectionData.Table = TableTextbox.Text;

                    (TableTextbox.SelectedItem as CommonAppObject).Children.Clear();
                    DbuiManager.UpdateChildren(TableTextbox.SelectedItem as CommonAppObject);
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message).ShowDialog();
                }

                foreach (CommonAppObject columnObject in (TableTextbox.SelectedItem as CommonAppObject).Children)
                {
                    Property property = new Property()
                    {
                        InternalName = columnObject.InternalName,
                        FriendlyName = columnObject.FriendlyName,
                    };

                    PropertyPanel panel = new PropertyPanel(property);
                    SearchPanel.AddControl(panel);
                }
            }
            else
            {
                string errorMessage = "The following fields can't be empty: ";
                bool firstError = true;

                foreach (string error in errors)
                {
                    if (!firstError)
                    {
                        errorMessage += ", ";
                    }
                    else
                    {
                        firstError = false;
                    }

                    errorMessage += error;
                }

                new MessageForm("Error", errorMessage).ShowDialog();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ServerTextbox.Text = string.Empty;
            DatabaseTextbox.DataSource = null;
            SchemaTextbox.DataSource = null;
            TableTextbox.DataSource = null;

            AuthenticationCheckbox.Checked = true;
            UsernameTextbox.Text = string.Empty;
            PasswordTextbox.Text = string.Empty;

            foreach (Control control in DatabasePanel.Controls)
            {
                control.Enabled = false;
            }

            SearchPanel.ClearControls();
            ServerTextbox.Focus();

            referenceObject = new CommonAppObject(CommonAppObjectType.Server);
            connectionData = new ConnectionProfile();
            DbuiManager.Profile = connectionData;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool resultStatus;
            Dictionary<string, string> searchTerms = new Dictionary<string, string>();

            foreach (PropertyPanel panel in SearchPanel.ControlList)
            {
                if (panel.IsSelected)
                {
                    searchTerms.Add(panel.InternalName, panel.Value);
                }
            }

            if (searchTerms.Count == 0)
            {
                new MessageForm("Alert", "You did not enter any seach terms");
            }
            else
            {
                try
                {
                    List<Entity> result = DbuiManager.Search(searchTerms, (TableTextbox.SelectedItem as CommonAppObject), out resultStatus);

                    if (resultStatus)
                    {
                        new TableForm(result).ShowDialog();
                    }
                    else
                    {
                        new MessageForm("Alert", "No results were returned").ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message).ShowDialog();
                }
            }
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            foreach (PropertyPanel panel in SearchPanel.ControlList)
            {
                panel.Reset();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}