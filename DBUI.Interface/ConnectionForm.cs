using DBUI.Business;
using DBUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
                txtUsername.Text = string.Empty;
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
            //UpdateAuthentication();

            if (profile.ValidateComplete())
            {
                new SearchForm(profile).ShowDialog();
            }
            else
            {
                new MessageForm("Alert", "You did not enter all the required information.").ShowDialog();
            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            ClearLowers((sender as TextBox).Tag);
        }

        private async void cbx_DropDown(object sender, EventArgs e)
        {
            ComboBox cbxSender = sender as ComboBox;
            ClearLowers(cbxSender.Tag);
            //UpdateAuthentication();

            StructureObjectType priorType = (StructureObjectType)Enum.Parse(typeof(StructureObjectType), cbxSender.Tag.ToString()) - 1;

            try
            {
                prbProgress.Style = ProgressBarStyle.Marquee;
                cbxSender.DataSource = await StructureManager.QueryChildren((StructureObject)profile.GetType().GetProperty(priorType.ToString()).GetValue(profile), profile);
            }
            catch (Exception ex)
            {
                new MessageForm("Error", ex.Message);
            }
            finally
            {
                prbProgress.Style = ProgressBarStyle.Blocks;
            }
        }

        private void edit_Complete(object sender, EventArgs e)
        {
            Control ctlSender = sender as Control;

            StructureObjectType objectType = (StructureObjectType)Enum.Parse(typeof(StructureObjectType), ctlSender.Tag.ToString());

            StructureObject structureObject;

            if (string.IsNullOrWhiteSpace(ctlSender.Text))
            {
                structureObject = null;
            }
            else
            {
                structureObject = new StructureObject(objectType)
                {
                    InternalName = ctlSender.Text,
                    FriendlyName = ctlSender.Text
                };
            }

            profile.GetType().GetProperty(ctlSender.Tag.ToString()).SetValue(profile, structureObject);
        }

        private void gbxAuthentication_Leave(object sender, EventArgs e)
        {
            if (chkWindowsAuthentication.Checked)
            {
                profile.AuthenticationType = AuthenticationType.Windows;
                profile.Username = string.Empty;
                profile.Password = string.Empty;
            }
            else
            {
                profile.AuthenticationType = AuthenticationType.Server;
                profile.Username = txtUsername.Text;
                profile.Password = txtPassword.Text;
            }
        }

        private void ClearLowers(object tag)
        {
            int value = EnumStringToInt(tag.ToString());

            List<ComboBox> clearableControls = gbxDatabase.Controls.OfType<ComboBox>().Where(x => EnumStringToInt(x.Tag.ToString()) > value).ToList();

            foreach (ComboBox c in clearableControls)
            {
                c.SelectedIndex = -1;
                c.DataSource = new List<StructureObject>();
            }
        }

        private int EnumStringToInt(string enumValue)
        {
            return (int)Enum.Parse(typeof(StructureObjectType), enumValue);
        }

        private void btnViewObject_Click(object sender, EventArgs e)
        {
            List<PropertyInfo> properties = profile.GetType().GetProperties().Where(x => x.PropertyType == typeof(StructureObject)).ToList();

            for (int counter = properties.Count - 1; counter >= 0; counter--)
            {
                if (properties[counter].GetValue(profile) != null)
                {
                    new StructureInspectorForm((StructureObject)properties[counter].GetValue(profile), profile).ShowDialog();
                    break;
                }
            }
        }
    }
}
