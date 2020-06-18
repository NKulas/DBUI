using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Models
{
    public class Entity
    {
        public Dictionary<StructureObject, string> Properties { get; }

        public Entity()
        {
            Properties = new Dictionary<StructureObject, string>();
        }
    }
}