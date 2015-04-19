using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Player : IPlayable, IRecordable
    {

        public void Play()
        {
            Console.WriteLine("Playing audio track");
        }

        public void Record()
        {
            Console.WriteLine("Recording audio track");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
