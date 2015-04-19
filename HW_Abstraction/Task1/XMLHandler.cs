using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML file was opened");
        }

        public override void Create()
        {
            Console.WriteLine("XML file was created");
        }

        public override void Change()
        {
            Console.WriteLine("XML file was changed");
        }

        public override void Save()
        {
            Console.WriteLine("XML file was saved");
        }
    }
}
