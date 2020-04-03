using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Models
{
    public enum AuthenticationType
    {
        Server, 
        Windows
    }

    public enum CommonAppObjectType
    {
        Server,
        Database,
        Schema,
        Table,
        Column,
        Property
    }
}