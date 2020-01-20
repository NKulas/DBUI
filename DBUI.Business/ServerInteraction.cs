using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Business
{
    public static class ServerInteraction
    {
        public static string Server { get; set; }
        public static string Database { get; set; }
        public static string Table { get; set; }
        public static SharedResources.eAuthenticationTypes AuthenticationType { get; set; }
        public static string Username { get; set; }
        public static SecureString Password { get; set; }

        public static string GetConnectionString()
        {
            string connectionString = $"Server={Server}; Database={Database}; ";
            if (AuthenticationType == SharedResources.eAuthenticationTypes.Windows) connectionString += "Integrated Security = SSPI;";
            else connectionString += $"User Id={Username}; Password={Password.ToString()};";

            return connectionString;
        }

        public static bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}