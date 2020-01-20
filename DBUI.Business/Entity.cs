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
            foreach (Property p in Properties)
            {
                loadProperties();
                p.Value = d[p.ColumnName].ToString();
            }
        }

        private void loadProperties()
        {
            /*DataSet columns = DataAccess.Query(#Sql to get columns)
            foreach (DataRow d in columns)
            {
                foreach (
            }*/
        }
    }
}