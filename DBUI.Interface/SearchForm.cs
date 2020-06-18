using DBUI.Business;
using DBUI.CustomControls;
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
    public partial class SearchForm : Form
    {
        private ConnectionProfile profile;
        private List<StructureObject> columns;

        public SearchForm()
        {
            InitializeComponent();
            profile = new ConnectionProfile();
            SetProperties();
        }

        private void SetProperties()
        {
            gbxSearch.ClearControls();

            if (profile.Table != null)
            {
                lblTable.Text = profile.Table.InternalName;

                try
                {
                    columns = StructureManager.QueryChildren(profile.Table, profile);

                    foreach (StructureObject column in columns)
                    {
                        gbxSearch.AddControl(new PropertyDisplayPanel(column));
                    }
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message);
                }
            }
            else
            {
                lblTable.Text = "Not connected";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> search = new Dictionary<string, string>();

            foreach (PropertyDisplayPanel p in gbxSearch.ControlList)
            {
                if (p.IsSelected)
                {
                    search.Add(p.InternalName, p.Value);
                }
            }

            if (search.Count > 0)
            {
                try
                {
                    List<Entity> result = DataManager.Search(search, columns, profile);
                    if (result.Count > 0)
                    {
                        new ResultForm(result).ShowDialog();
                    }
                    else
                    {
                        new MessageForm("Alert", "No results were returned").ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    new MessageForm("Error", ex.Message);
                }
            }
            else
            {
                new MessageForm("Alert", "You did not enter any search terms").ShowDialog();
            }
        }

        private void btnManageConnection_Click(object sender, EventArgs e)
        {
            new ConnectionForm(profile).ShowDialog();
            SetProperties();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (PropertyDisplayPanel p in gbxSearch.ControlList)
            {
                p.Reset();
            }
        }
    }
}
