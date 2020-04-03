using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUI.Models
{
    public class Property : CommonAppObject
    {
        public string Value { get; set; }

        public Property() : base(CommonAppObjectType.Property)
        {
            //TODO: some inherited properties are not used, look into better structuring
        }
    }
}