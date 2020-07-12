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
    public partial class StructureInspectorForm : Form
    {
        private ConnectionProfile profile;
        private StructureObject structureObject;

        public StructureInspectorForm(StructureObject _structureObject, ConnectionProfile _profile)
        {
            InitializeComponent();

            profile = _profile;
            structureObject = _structureObject;

            if (structureObject.ObjectType == StructureObjectType.Table)
            {
                txtName.Enabled = true;
            }
            else
            {
                txtName.Enabled = false;
            }

            txtName.Text = structureObject.InternalName;
            txtFriendlyName.Text = structureObject.FriendlyName;
            lblObjectTypeOutput.Text = structureObject.ObjectType.ToString();
            lblChildTypeOutput.Text = (structureObject.ObjectType + 1).ToString();
        }

        private async void StructureInspectorForm_Load(object sender, EventArgs e)
        {
            lstChildren.DataSource = await StructureManager.QueryChildren(structureObject, profile);
        }

        private async void btnClose_Click(object sender, EventArgs e)
        {
            Close();

            object existingObject = typeof(ConnectionProfile).GetProperties().FirstOrDefault(x => x.Name == structureObject.ObjectType.ToString()).GetValue(profile);
            
            string oldName = ((StructureObject)existingObject).InternalName;
            if (txtName.Text != oldName)
            {
                bool result = await StructureManager.UpdateName((StructureObject)existingObject, txtName.Text, profile);

                if (!result)
                {
                    new MessageForm("Alert", "Data could not be updated.").ShowDialog();
                }
            }
        }
    }
}
