using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    [AttributeUsage(AttributeTargets.Property)]
    class ForPrintAttribute : System.Attribute
    {
        public string Color { get; set; }
    }
}
