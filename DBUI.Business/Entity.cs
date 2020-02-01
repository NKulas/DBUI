using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUI.Data;

namespace DBUI.Business
{
    public class Entity
    {
        public List<Property> Properties { get; set; }

        public Entity(DataRow d)
        {
            loadProperties();
            foreach (Property p in Properties)
            {
                p.Value = d[p.ColumnName].ToString();
            }
        }

        private void loadProperties()
        {
            Properties = new List<Property>();
            DataTable columns = DataAccess.Query($"SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '{ServerInteraction.Table}';");
            foreach (DataRow d in columns.Rows)
            {
                Properties.Add(new Property(d.ItemArray[0].ToString(), d.ItemArray[0].ToString()));  
            }
        }
    }
}