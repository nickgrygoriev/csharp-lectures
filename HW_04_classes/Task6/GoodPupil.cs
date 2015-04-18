using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil: studying good");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil: reading good");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil: writing good");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil: relaxing normally");
        }
    }
}
