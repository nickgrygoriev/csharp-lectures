using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.Add(5);
            list.Add(10);
            list.Add(20);

            Console.WriteLine("Length of the list: {0}", list.Length);
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("List[{0}]: {1}", i, list[i]);
            }

            Console.ReadKey();
        }
    }
}
