using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Business
{
    public class Property
    {
        public string ColumnName { get; private set; }
        public string DisplayAlias { get; private set; }
        public string Value { get; set; }

        public Property(string columnName, string alias)
        {
            ColumnName = columnName;
            DisplayAlias = alias;
        }
    }
}
