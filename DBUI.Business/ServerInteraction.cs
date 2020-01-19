using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Business
{
    public class ServerInteraction
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Table { get; set; }
        public SharedResources.eAuthenticationTypes AuthenticationType { get; set; }
        public string Username { get; set; }
        public SecureString Password { get; set; }

        public bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}