using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Business
{
    public class ReferenceEntity
    {
        public List<ReferenceProperty> ReferenceProperties { get; } = new List<ReferenceProperty>();

        public List<SqlParameter> GetSqlParameters()
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();

            foreach (ReferenceProperty rp in ReferenceProperties)
            {
                parameterList.Add(rp.GetParameter());
            }

            return parameterList;
        }

        public bool GetSqlCommandString(out string CommandString)
        {
            string selectClause = string.Empty;
            string whereClause = string.Empty;
            bool firstSelectFlag = true;
            bool firstWhereFlag = true;

            foreach (ReferenceProperty rp in ReferenceProperties)
            {
                if (!firstSelectFlag)
                {
                    selectClause += ", ";
                }
                else
                {
                    firstSelectFlag = false;
                }
                selectClause += rp.SqlCommand;

                if (rp.IsSelected)
                {
                    if (!firstWhereFlag)
                    {
                        whereClause += " AND ";
                    }
                    else
                    {
                        firstWhereFlag = false;
                    }
                    whereClause += $"{rp.ColumnName}=@{rp.ColumnName}";
                }
            }

            if (firstWhereFlag)
            {
                CommandString = string.Empty;
                return false;
            }
            else
            {
                CommandString = $"SELECT {selectClause} FROM {ServerInteraction.Table} WHERE {whereClause};";
                return true;
            }
        }
    }
}