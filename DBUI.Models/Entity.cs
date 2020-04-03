using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Models
{
    public class Entity
    {
        public List<Property> Properties { get; }

        public Entity()
        {
            Properties = new List<Property>();
        }
    }
}