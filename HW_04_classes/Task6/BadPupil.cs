using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil: studying badly");
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil: reading badly");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil: writing badly");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil: relaxing a lot");
        }
    }
}
