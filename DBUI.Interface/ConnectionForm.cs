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

        public ConnectionForm()
        {
            InitializeComponent();

            profile = new ConnectionProfile();
        }

        private void Setup()
        {
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
                txtPassword.Enabled = false;
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

            if (profile.ValidateComplete())
            {
                new SearchForm(profile).ShowDialog();
            }
            else
            {
                new MessageForm("Alert", "You did not enter all the required information.").ShowDialog();
            }
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

        private async void cbxDatabase_DropDown(object sender, EventArgs e)
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
                    prbDatabase.Style = ProgressBarStyle.Marquee;
                    cbxDatabase.DataSource = await StructureManager.QueryChildren(server, profile);
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message);
                }
                finally
                {
                    prbDatabase.Style = ProgressBarStyle.Blocks;
                }
            }
        }

        private async void cbxSchema_DropDown(object sender, EventArgs e)
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
                    prbSchema.Style = ProgressBarStyle.Marquee;
                    cbxSchema.DataSource = await StructureManager.QueryChildren(database, profile);
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message);
                }
                finally
                {
                    prbSchema.Style = ProgressBarStyle.Blocks;
                }
            }
        }

        private async void cbxTable_DropDown(object sender, EventArgs e)
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
                    prbTable.Style = ProgressBarStyle.Marquee;
                    cbxTable.DataSource = await StructureManager.QueryChildren(schema, profile);
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message);
                }
                finally
                {
                    prbTable.Style = ProgressBarStyle.Blocks;
                }
            }
        }
    }
}
