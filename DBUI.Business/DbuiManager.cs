using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUI.Data;
using DBUI.Models;

namespace DBUI.Business
{
    public static class DbuiManager
    {
        public static ConnectionProfile Profile { get; set; }

        private const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        private const string NUMBERS = "0123456789";

        private static void BuildConnectionString()
        {
            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();

            if (Profile.Server != null)
            {
                connectionBuilder.DataSource = Profile.Server;
            }

            if (Profile.Database != null)
            {
                connectionBuilder.InitialCatalog = Profile.Database;
            }

            if (Profile.AuthenticationType == AuthenticationType.Windows)
            {
                connectionBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionBuilder.IntegratedSecurity = false;
                connectionBuilder.UserID = Profile.Username;
                connectionBuilder.Password = Profile.Password;
            }

            DataAccess.ConnectionString = connectionBuilder.ConnectionString;
        }

        public static bool TestConnection()
        {
            BuildConnectionString();

            if (DataAccess.TestConnection()) return true;
            else return false;
        }

        public static void UpdateChildren(CommonAppObject caa)
        {
            BuildConnectionString();

            switch (caa.ObjectType)
            {
                case CommonAppObjectType.Server:

                    DataTable result = DataAccess.Query($"SELECT * FROM master.dbo.sysdatabases;");
                    foreach (DataRow row in result.Rows)
                    {
                        caa.Children.Add(new CommonAppObject(CommonAppObjectType.Database) { InternalName = row[0].ToString() });
                    }
                    break;

                case CommonAppObjectType.Database:

                    result = DataAccess.Query($"SELECT * FROM sys.schemas;");
                    foreach (DataRow row in result.Rows)
                    {
                        caa.Children.Add(new CommonAppObject(CommonAppObjectType.Schema) { InternalName = row[0].ToString() });
                    }
                    break;

                case CommonAppObjectType.Schema:

                    result = DataAccess.Query($"SELECT name FROM sys.tables WHERE schema_id = SCHEMA_ID('{caa.InternalName}');");
                    //result = DataAccess.Query($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES;");
                    foreach (DataRow row in result.Rows)
                    {
                        caa.Children.Add(new CommonAppObject(CommonAppObjectType.Table) { InternalName = row[0].ToString() });
                    }
                    break;

                case CommonAppObjectType.Table:

                    result = DataAccess.Query($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{caa.InternalName}';");
                    foreach (DataRow row in result.Rows)
                    {
                        caa.Children.Add(
                            new CommonAppObject(CommonAppObjectType.Column)
                            {
                                InternalName = row[0].ToString(),
                                FriendlyName = GuessFriendlyName(row[0].ToString())
                            });
                    }
                    break;

                //case CommonAppObjectType.Column:

                default:
                    throw new Exception("An invalid CommonAppObject type was given");
            }

        }
        //Get schemas: SELECT * FROM sys.schemas;
        //Get tables: SELECT * FROM sys.tables WHERE schema_id = SCHEMA_ID('dbo');
        //Get columns: SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = (table name);

        public static List<Entity> Search(Dictionary<string, string> searchTerms, CommonAppObject table, out bool resultsReturned)
        {
            string commandString = $"SELECT * FROM {Profile.Table} WHERE ";
            List<SqlParameter> parameters = new List<SqlParameter>();
            bool firstWhere = true;
            int numberOfConditions = 0;

            foreach (string key in searchTerms.Keys)
            {
                if (!string.IsNullOrWhiteSpace(searchTerms[key]))
                {
                    if (firstWhere)
                    {
                        commandString += $"{key} = @{key}";
                        firstWhere = false;
                    }
                    else
                    {
                        commandString += $" AND {key} = @{key}";
                    }
                    parameters.Add(new SqlParameter($"{key}", searchTerms[key]));
                    numberOfConditions++;
                }
            }

            commandString += ";";
            try
            {
                DataTable result = DataAccess.Query(commandString, parameters.ToArray());

                if (result != null && (result.Rows.Count != 0))
                {
                    List<Entity> returnList = new List<Entity>();
                    foreach (DataRow row in result.Rows)
                    {
                        Entity resultEntity = new Entity();

                        int counter = 0;
                        foreach (var column in result.Columns)
                        {
                            Property newProperty = new Property()
                            {
                                FriendlyName = GuessFriendlyName(column.ToString()),
                                InternalName = column.ToString(),
                                Value = row[counter].ToString()
                            };

                            table.Children.FirstOrDefault(x => x.InternalName == column.ToString()).Children.Add(newProperty);
                            resultEntity.Properties.Add(newProperty);

                            counter++;
                        }
                        returnList.Add(resultEntity);
                    }
                    resultsReturned = true;
                    return returnList;
                }
                else
                {
                    resultsReturned = false;
                    return null;
                }
            }
            catch
            {
                throw;
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
                else result += c;

                lastUpper = thisUpper;
                lastLower = thisLower;
                lastNumber = thisNumber;
            }

            return result;
        }
    }
}