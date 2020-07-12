using DBUI.Models;
using DBUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBUI.Business
{
    public static class StructureManager
    {
        private const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        private const string NUMBERS = "0123456789";

        public static async Task<List<StructureObject>> QueryChildren(StructureObject parent, ConnectionProfile profile)
        {
            DataAccess.ConnectionString = profile.GetConnectionString();
            List<StructureObject> children = new List<StructureObject>();
            string query;
            StructureObjectType childType;

            switch (parent.ObjectType)
            {
                case StructureObjectType.Server:
                    query = "SELECT * FROM sys.databases;";
                    childType = StructureObjectType.Database;
                    break;

                case StructureObjectType.Database:
                    query = $"SELECT * FROM sys.schemas;";
                    childType = StructureObjectType.Schema;
                    break;

                case StructureObjectType.Schema:
                    query = $"SELECT name FROM sys.tables WHERE schema_id = SCHEMA_ID('{parent.InternalName}');";
                    childType = StructureObjectType.Table;
                    break;

                case StructureObjectType.Table:
                    query = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{parent.InternalName}';";
                    childType = StructureObjectType.Column;
                    break;

                default:
                    query = "";
                    childType = StructureObjectType.Column;
                    break;
            }

            try
            {
                DataTable result = await DataAccess.QueryAsync(query);

                foreach (DataRow row in result.Rows)
                {
                    children.Add(
                        new StructureObject(childType)
                        {
                            InternalName = row[0].ToString(),
                            FriendlyName = GuessFriendlyName(row[0].ToString())
                        }
                    );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return children;
        }

        public static async Task<bool> UpdateName(StructureObject existingObject, string newName, ConnectionProfile profile)
        {
            DataAccess.ConnectionString = profile.GetConnectionString();
            string query;
            List<SqlParameter> parameters = new List<SqlParameter>();

            switch (existingObject.ObjectType)
            {
                case StructureObjectType.Server:
                    return false;

                case StructureObjectType.Database:
                    return false;

                case StructureObjectType.Schema:
                    return false;

                case StructureObjectType.Table:
                    //query = $"ALTER TABLE @item RENAME TO @newName;";
                    query = $"sp_rename '{existingObject.InternalName}', '{newName}';";
                    /*parameters.Add(
                        new SqlParameter("item", existingObject.InternalName)
                    );
                    parameters.Add(
                        new SqlParameter("newName", newName)
                    );*/
                    break;

                case StructureObjectType.Column:
                    return false;

                default:
                    return false;
            }

            try
            {
                int result = await DataAccess.NonQueryAsync(query, parameters.ToArray());

                if (result == -1)
                {
                    existingObject.InternalName = newName;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private static string GuessFriendlyName(string internalName)
        {
            string result = "";
            bool lastUpper = false;
            bool lastLower = false;
            bool lastNumber = false;

            foreach (char c in internalName)
            {
                bool thisUpper = UPPERCASE.Contains(c);
                bool thisLower = LOWERCASE.Contains(c);
                bool thisNumber = NUMBERS.Contains(c);

                if (lastLower && thisUpper) { result += $" {c}"; }
                else if (lastNumber && (thisUpper || thisLower)) result += $" {c}";
                else if ((lastLower || lastUpper) && thisNumber) result += $" {c}";
                else result += c;

                lastUpper = thisUpper;
                lastLower = thisLower;
                lastNumber = thisNumber;
            }

            return result;
        }
    }
}
