using DBUI.Business;
using DBUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUI.Interface
{
    public partial class ConnectionForm : Form
    {
        private ConnectionProfile profile;

        public ConnectionForm(ConnectionProfile _profile)
        {
            InitializeComponent();

            profile = _profile;
            Setup();
        }

        private void Setup()
        {
            cbxDatabase.ValueMember = "InternalName";
            cbxDatabase.DisplayMember = "InternalName";

            cbxSchema.ValueMember = "InternalName";
            cbxSchema.DisplayMember = "InternalName";

            cbxTable.ValueMember = "InternalName";
            cbxTable.DisplayMember = "InternalName";

            if (profile.Server != null)
            {
                txtServer.Text = profile.Server.InternalName;
            }

            if (profile.AuthenticationType == AuthenticationType.Windows)
            {
                chkWindowsAuthentication.Checked = true;
            }
            else
            {
                chkWindowsAuthentication.Checked = false;
                txtUsername.Text = profile.Username;
                txtPassword.Text = profile.Password;
            }

            if (profile.Database != null)
            {
                cbxDatabase.Text = profile.Database.InternalName;
            }

            if (profile.Schema != null)
            {
                cbxSchema.Text = profile.Schema.InternalName;
            }

            if (profile.Table != null)
            {
                cbxTable.Text = profile.Table.InternalName;
            }
        }

        private void chkWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                txtUsername.Enabled = false;
                txtUsername.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                txtPassword.Enabled = false;
                txtPassword.Text = string.Empty;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            UpdateProfile();
            Close();
        }

        private void UpdateProfile()
        {
            profile.Server = new StructureObject(StructureObjectType.Server)
            {
                InternalName = txtServer.Text,
                FriendlyName = txtServer.Text
            };

            if (chkWindowsAuthentication.Checked)
            {
                profile.AuthenticationType = AuthenticationType.Windows;
            }
            else
            {
                profile.AuthenticationType = AuthenticationType.Server;
                profile.Username = txtUsername.Text;
                profile.Password = txtPassword.Text;
            }

            profile.Database = new StructureObject(StructureObjectType.Database)
            {
                InternalName = cbxDatabase.Text,
                FriendlyName = cbxDatabase.Text
            };

            profile.Schema = new StructureObject(StructureObjectType.Schema)
            {
                InternalName = cbxSchema.Text,
                FriendlyName = cbxSchema.Text
            };

            profile.Table = new StructureObject(StructureObjectType.Table)
            {
                InternalName = cbxTable.Text,
                FriendlyName = cbxTable.Text
            };
        }

        private void cbxDatabase_DropDown(object sender, EventArgs e)
        {
            if (txtServer.Text != string.Empty)
            {
                UpdateProfile();

                StructureObject server = new StructureObject(StructureObjectType.Server)
                {
                    InternalName = txtServer.Text
                };

                try
                {
                    cbxDatabase.DataSource = StructureManager.QueryChildren(server, profile);
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message);
                }
            }
        }

        private void cbxSchema_DropDown(object sender, EventArgs e)
        {
            UpdateProfile();

            if (cbxDatabase.Text != string.Empty)
            {
                StructureObject database = new StructureObject(StructureObjectType.Database)
                {
                    InternalName = cbxDatabase.Text
                };

                try
                {
                    cbxSchema.DataSource = StructureManager.QueryChildren(database, profile);
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message);
                }
            }
        }

        private void cbxTable_DropDown(object sender, EventArgs e)
        {
            UpdateProfile();

            if (cbxSchema.Text != string.Empty)
            {
                StructureObject schema = new StructureObject(StructureObjectType.Schema)
                {
                    InternalName = cbxSchema.Text
                };

                try
                {
                    cbxTable.DataSource = StructureManager.QueryChildren(schema, profile);
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message);
                }
            }
        }
    }
}
