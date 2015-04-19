using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT file was opened");
        }

        public override void Create()
        {
            Console.WriteLine("TXT file was created");
        }

        public override void Change()
        {
            Console.WriteLine("TXT file was changed");
        }

        public override void Save()
        {
            Console.WriteLine("TXT file was saved");
        }
    }
}
