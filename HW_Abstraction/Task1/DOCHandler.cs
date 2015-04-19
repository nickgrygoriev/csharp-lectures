using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC file was opened");
        }

        public override void Create()
        {
            Console.WriteLine("DOC file was created");
        }

        public override void Change()
        {
            Console.WriteLine("DOC file was changed");
        }

        public override void Save()
        {
            Console.WriteLine("DOC file was saved");
        }
    }
}
