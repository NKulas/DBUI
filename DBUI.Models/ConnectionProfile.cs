using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Models
{
    public class ConnectionProfile
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Schema { get; set; }
        public string Table { get; set; }

        //public CommonResources.AuthenticationType authentication { get; set; }
        public AuthenticationType AuthenticationType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<string> Permissions { get; } = new List<string>();

        public string GetConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}