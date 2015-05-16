using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker();

                Console.WriteLine("Input worker's surname and initials:");
                workers[i].name = Console.ReadLine();

                Console.WriteLine("Input worker's position:");
                workers[i].position = Console.ReadLine();

                Console.WriteLine("Input year of worker's hiring:");
                try
                {
                    workers[i].hiringYear = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    return;
                }
            }

            Array.Sort(workers, new WorkerComparer());

            //foreach (Worker worker in workers)
            //{
            //    Console.WriteLine(worker.name);
            //}

            Console.WriteLine("Input worker's experience (in years):");
            int expirience;
            if (Int32.TryParse(Console.ReadLine(), out expirience))
            {
                foreach (Worker worker in workers)
                {
                    if (worker.hiringYear + expirience > DateTime.Now.Year)
                    {
                        Console.WriteLine(worker.name.Substring(0, worker.name.IndexOf(' '))); //Surname output
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect expirience");
            }

            Console.ReadKey();
        }
    }

    class WorkerComparer : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            string a = x.name;
            string b = y.name;

            return a.CompareTo(b);
        }
    }
}
