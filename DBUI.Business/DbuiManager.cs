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
        /*FOR TESTING ONLY*/public static DataTable result { get; private set; }

        private const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        private const string NUMBERS = "0123456789";

        public static bool TestConnection()
        {
            if (Profile.AuthenticationType == "Windows") DataAccess.ConnectionString = $"Server={Profile.Server}; Database={Profile.Database}; Integrated Security=SSPI;";
            else DataAccess.ConnectionString = $"Provider=DQLOLEDB;Server={Profile.Server}; Database={Profile.Database};User Id={Profile.Username}; Password={Profile.Password}";

            if (DataAccess.TestConnection()) return true;
            else return false;
        }

        public static List<Property> GetProperties()
        {
            SqlParameter[] parameters = new SqlParameter[1] { new SqlParameter("tableName", Profile.Table) };
            DataTable names = DataAccess.Query($"SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = @tableName;", parameters);

            List<Property> properties = new List<Property>();
            foreach (DataRow name in names.Rows)
            {
                Property property = new Property();
                property.SqlName = name[0].ToString();

                string finalName = "";
                bool lastUpper = false;
                bool lastLower = false;
                bool lastNumber = false;
                foreach (char c in name[0].ToString().ToCharArray())
                {
                    bool thisUpper = UPPERCASE.Contains(c);
                    bool thisLower = LOWERCASE.Contains(c);
                    bool thisNumber = NUMBERS.Contains(c);

                    //Try to intelligently guess what the human readable form is
                    if (thisUpper && lastLower) finalName += $" {c}";
                    else if (thisUpper && lastUpper) finalName += $"{c}";

                    else if (thisNumber && (lastUpper || lastLower)) finalName += $" {c}";
                    else if (thisNumber && lastNumber) finalName += $"{c}";
                    else finalName += $"{c}";

                    lastUpper = thisUpper;
                    lastLower = thisLower;
                    lastNumber = thisNumber;
                }
                property.DisplayAlias = finalName;

                properties.Add(property);
            }
            return properties;
        }

        public static bool Search(Entity entity)
        {
            string commandString = $"SELECT * FROM {Profile.Table} WHERE ";
            List<SqlParameter> parameters = new List<SqlParameter>();
            bool firstWhere = true;
            int numberOfConditions = 0;

            foreach (Property p in entity.Properties)
            {
                if (!string.IsNullOrWhiteSpace(p.Value))
                {
                    if (firstWhere)
                    {
                        commandString += $"{p.SqlName} = @{p.SqlName}";
                        firstWhere = false;
                    }
                    else
                    {
                        commandString += $" AND {p.SqlName} = @{p.SqlName}";
                    }
                    parameters.Add(new SqlParameter($"{p.SqlName}", p.Value));
                    numberOfConditions++;
                }
            }

            if (numberOfConditions == 0) return false;
            else
            {
                commandString += ";";
                try
                {
                    result = DataAccess.Query(commandString, parameters.ToArray());
                    return true;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}