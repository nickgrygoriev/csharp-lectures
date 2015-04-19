using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type QUIT to quit from player");
            Player p = new Player();
            
            while (true)
            {
                Console.WriteLine("\nInput operation (play/record/pause/stop):");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "play":
                        p.Play();
                        break;
                    case "record":
                        p.Record();
                        break;
                    case "pause":
                        p.Pause();
                        break;
                    case "stop":
                        p.Stop();
                        break;
                    case "QUIT":
                        return;
                    default:
                        Console.WriteLine("Unknown operation");
                        break;
                }
            }
        }
    }
}
