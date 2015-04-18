using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class ClassRoom
    {
        public ClassRoom(Pupil first, Pupil second)
        {
            first.Study();
            first.Read();
            first.Write();
            first.Relax();

            second.Study();
            second.Read();
            second.Write();
            second.Relax();
        }

        public ClassRoom(Pupil first, Pupil second, Pupil third) 
            : this(first, second)
        {
            third.Study();
            third.Read();
            third.Write();
            third.Relax();
        }

        public ClassRoom(Pupil first, Pupil second, Pupil third, Pupil fourth) 
            : this(first, second, third)
        {
            fourth.Study();
            fourth.Read();
            fourth.Write();
            fourth.Relax();
        }
    }
}
