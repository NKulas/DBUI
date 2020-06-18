using DBUI.Data;
using DBUI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Business
{
    public static class DataManager
    {
        public static List<Entity> Search(Dictionary<string, string> searchTerms, List<StructureObject> returnColumns, ConnectionProfile profile)
        {
            string query = $"SELECT * FROM {profile.Table.InternalName} WHERE ";

            List<SqlParameter> parameters = new List<SqlParameter>();
            bool firstIteration = true;

            foreach (string term in searchTerms.Keys)
            {
                if (firstIteration)
                {
                    query += $"{term} = @{term}";
                    firstIteration = false;
                }
                else
                {
                    query += $", {term} = @{term}";
                }

                parameters.Add(new SqlParameter($"@{term}", searchTerms[term]));
            }

            query += ";";

            DataAccess.ConnectionString = profile.GetConnectionString();
            DataTable databaseResult = DataAccess.Query(query, parameters.ToArray());

            List<Entity> returnableResults = new List<Entity>();
            foreach (DataRow row in databaseResult.Rows)
            {
                Entity entity = new Entity();

                foreach (StructureObject column in returnColumns)
                {
                    entity.Properties.Add(column, row[column.InternalName].ToString());
                }

                returnableResults.Add(entity);
            }

            return returnableResults;
        }
    }
}
