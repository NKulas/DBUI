using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUI.Models;

namespace DBUI.Interface
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(DataTable data)
        {
            InitializeComponent();
            dgvData.DataSource = data;
        }

        public ResultForm(List<Entity> entities)
        {
            InitializeComponent();
            dgvData.ColumnCount = entities[0].Properties.Count;

            for (int i = 0; i < dgvData.ColumnCount; i++)
            {
                dgvData.Columns[i].Name = entities[0].Properties.ElementAt(i).Key.FriendlyName;
            }

            for (int i = 0; i < entities.Count; i++)
            {
                string[] row = new string[dgvData.ColumnCount];

                for (int j = 0; j < dgvData.ColumnCount; j++)
                {
                    row[j] = entities[i].Properties.ElementAt(j).Value;
                }

                dgvData.Rows.Add(row);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}