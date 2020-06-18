using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Models
{
    public class StructureObject
    {
        public StructureObject(StructureObjectType objectType)
        {
            ObjectType = objectType;
            //Children = new List<StructureObject>();
        }

        public StructureObjectType ObjectType { get; }
        public string InternalName { get; set; }
        public string FriendlyName { get; set; }
        //public List<StructureObject> Children { get; }
    }
}
