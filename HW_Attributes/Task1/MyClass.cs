using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyClass
    {
        [ForPrint(Color="Red")]
        public string Prop1 { get; set; }

        [ForPrint(Color="Green")]
        public string Prop2 { get; set; }

        [ForPrint(Color="Yellow")]
        public string Prop3 { get; set; }

        public string Prop4 { get; set; }

        public string Prop5 { get; set; }

        public MyClass()
        {
            Prop1 = "Hello from Prop1";
            Prop2 = "Hello from Prop2";
            Prop3 = "Hello from Prop3";
            Prop4 = "Hello from Prop4";
            Prop5 = "Hello from Prop5";
        }
    }
}
