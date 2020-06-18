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

        public static List<StructureObject> QueryChildren(StructureObject parent, ConnectionProfile profile)
        {
            DataAccess.ConnectionString = profile.GetConnectionString();
            List<StructureObject> children = new List<StructureObject>();

            switch (parent.ObjectType)
            {
                case StructureObjectType.Server:

                    DataTable result = DataAccess.Query($"SELECT * FROM master.dbo.sysdatabases;");
                    foreach (DataRow row in result.Rows)
                    {
                        children.Add(
                            new StructureObject(StructureObjectType.Database)
                            {
                                InternalName = row[0].ToString(),
                                FriendlyName = GuessFriendlyName(row[0].ToString())
                            }
                        );
                    }
                    break;

                case StructureObjectType.Database:

                    result = DataAccess.Query($"SELECT * FROM sys.schemas;");
                    foreach (DataRow row in result.Rows)
                    {
                        children.Add(
                            new StructureObject(StructureObjectType.Schema)
                            {
                                InternalName = row[0].ToString(),
                                FriendlyName = GuessFriendlyName(row[0].ToString())
                            }
                        );
                    }
                    break;

                case StructureObjectType.Schema:

                    result = DataAccess.Query($"SELECT name FROM sys.tables WHERE schema_id = SCHEMA_ID('{parent.InternalName}');");
                    foreach (DataRow row in result.Rows)
                    {
                        children.Add(
                            new StructureObject(StructureObjectType.Table)
                            {
                                InternalName = row[0].ToString(),
                                FriendlyName = GuessFriendlyName(row[0].ToString())
                            }
                        );
                    }
                    break;

                case StructureObjectType.Table:

                    result = DataAccess.Query($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{parent.InternalName}';");
                    foreach (DataRow row in result.Rows)
                    {
                        children.Add(
                            new StructureObject(StructureObjectType.Column)
                            {
                                InternalName = row[0].ToString(),
                                FriendlyName = GuessFriendlyName(row[0].ToString())
                            }
                        );
                    }
                    break;
            }

            return children;
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
