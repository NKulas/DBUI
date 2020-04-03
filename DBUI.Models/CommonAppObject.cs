using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUI.Models;

namespace DBUI.Models
{
    public class CommonAppObject
    {
        public CommonAppObjectType ObjectType { get; private set; }
        public string FriendlyName { get; set; }
        public string InternalName { get; set; }
        public List<CommonAppObject> Children { get; }

        public CommonAppObject(CommonAppObjectType objectType)
        {
            ObjectType = objectType;
            Children = new List<CommonAppObject>();
        }
    }
}