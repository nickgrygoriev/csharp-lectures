using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil firstPupil = new ExcellentPupil();
            Pupil secondPupil = new GoodPupil();
            ClassRoom cr1 = new ClassRoom(firstPupil, secondPupil);

            Console.WriteLine();
            Pupil thirdPupil = new BadPupil();
            ClassRoom cr2 = new ClassRoom(firstPupil, secondPupil, thirdPupil);

            Console.WriteLine();
            Pupil fourthPupil = new ExcellentPupil();
            ClassRoom cr3 = new ClassRoom(firstPupil, secondPupil, thirdPupil, fourthPupil);

            Console.ReadKey();
        }
    }
}
