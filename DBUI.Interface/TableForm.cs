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
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        public TableForm(List<Entity> entities)
        {
            InitializeComponent();
            DataTableView.ColumnCount = entities[0].Properties.Count;

            for (int i = 0; i < DataTableView.ColumnCount; i++)
            {
                DataTableView.Columns[i].Name = entities[0].Properties[i].DisplayAlias;
            }

            for (int i = 0; i < entities.Count; i++)
            {
                string[] row = new string[DataTableView.ColumnCount];

                for (int j = 0; j < DataTableView.ColumnCount; j++)
                {
                    row[j] = entities[i].Properties[j].Value;
                }

                DataTableView.Rows.Add(row);
            }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}