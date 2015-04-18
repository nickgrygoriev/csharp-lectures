using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent pupil: studying excellently");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent pupil: reading excellently");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent pupil: writing excellently");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent pupil: relaxing a little");
        }
    }
}
