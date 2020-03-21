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
        private Entity referenceEntity = new Entity();

        public MainForm()
        {
            InitializeComponent();
            DatabaseTextbox.DisplayMember = "InternalName";
            referenceEntity.Properties = new List<Property>();
        }

        private bool SetCredentials()
        {
            bool validInput = true;

            if (AuthenticationCheckbox.Checked) connectionData.AuthenticationType = AuthenticationType.Windows;
            else
            {
                connectionData.AuthenticationType = AuthenticationType.Server;

                if (UsernameTextbox.Text != string.Empty) connectionData.Username = UsernameTextbox.Text;
                else
                {
                    validInput = false;
                }

                if (PasswordTextbox.Text != string.Empty)
                {
                    connectionData.Password = PasswordTextbox.Text;
                }
                else
                {
                    validInput = false;
                }
            }

            if (validInput)
            {
                DbuiManager.Profile = connectionData;
            }

            return validInput;
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
                SearchPanel.ClearControls();
                referenceEntity.Properties = new List<Property>();
                DbuiManager.Profile = connectionData;
                DbuiManager.Profile.Table = TableTextbox.Text;

                try
                {
                    List<Property> lp = DbuiManager.GetProperties();
                    foreach (Property p in lp)
                    {
                        referenceEntity.Properties.Add(p);
                        ReferencePropertyPanel pan = new ReferencePropertyPanel(p);
                        SearchPanel.AddControl(pan);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

                MessageBox.Show(errorMessage);
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
            searchEntity.Properties = new List<Property>();
            foreach (ReferencePropertyPanel rpp in SearchPanel.ControlList)
            {
                if (rpp.IsSelected)
                {   
                    searchEntity.Properties.Add(new Property
                    {
                        DisplayAlias = referenceEntity.Properties[index].DisplayAlias,
                        SqlName = referenceEntity.Properties[index].SqlName,
                        Value = rpp.UserText
                    });
                }
                index++;
            }

            List<Entity> result = DbuiManager.Search(searchEntity, out bool resultStatus);
            if (resultStatus)
            {
                TableForm oForm = new TableForm(result);
                oForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No results were returned", "Alert", MessageBoxButtons.OK);
            }
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
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

        private void DatabaseTextbox_DropDown(object sender, EventArgs e)
        {
            try
            {
                referenceObject.InternalName = ServerTextbox.Text;

                if (SetCredentials())
                {
                    referenceObject.Children.Clear();
                    DbuiManager.UpdateChildren(referenceObject);

                    DatabaseTextbox.DataSource = null;
                    DatabaseTextbox.DataSource = referenceObject.Children;
                    DatabaseTextbox.DisplayMember = "InternalName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SchemaTextbox_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (SetCredentials())
                {
                    (DatabaseTextbox.SelectedItem as CommonAppObject).Children.Clear();
                    DbuiManager.Profile.Server = ServerTextbox.Text;
                    DbuiManager.UpdateChildren(DatabaseTextbox.SelectedItem as CommonAppObject);

                    SchemaTextbox.DataSource = null;
                    SchemaTextbox.DataSource = (DatabaseTextbox.SelectedItem as CommonAppObject).Children;
                    SchemaTextbox.DisplayMember = "InternalName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void TableTextbox_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (SetCredentials())
                {
                    (SchemaTextbox.SelectedItem as CommonAppObject).Children.Clear();
                    DbuiManager.Profile.Server = ServerTextbox.Text;
                    DbuiManager.Profile.Database = DatabaseTextbox.Text;
                    DbuiManager.UpdateChildren(SchemaTextbox.SelectedItem as CommonAppObject);

                    TableTextbox.DataSource = null;
                    TableTextbox.DataSource = (SchemaTextbox.SelectedItem as CommonAppObject).Children;
                    TableTextbox.DisplayMember = "InternalName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}