using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUI.Data;

namespace DBUI.Business
{
    public class EntityCollection : List<Entity>
    {
        public List<SqlParameter> Parameters { get; } = new List<SqlParameter>();

        public EntityCollection()
        {
            DataAccess.ConnectionString = ServerInteraction.GetConnectionString();
        }

        public bool DoSearchQuery(string commandString, List<SqlParameter> parameters)
        {
            System.Threading.Thread.Sleep(1000); //One second delay to prevent use in a DOS attack
            try
            {
                DataTable result = DataAccess.Query(commandString, parameters.ToArray());

                if (result != null)
                {
                    foreach (DataRow d in result.Rows)
                    {
                        Add(new Entity(d));
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}