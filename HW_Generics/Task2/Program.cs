using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

            dictionary.Add(2, "someString1");
            dictionary.Add(21, "someString2");
            dictionary.Add(8, "someString3");
            //dictionary.Add(21, "again21");

            Console.WriteLine("Length of the dictionary: {0}", dictionary.Length);

            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary[21]);
            Console.WriteLine(dictionary[8]);
            //Console.WriteLine(dictionary[5]);
            Console.ReadKey();
        }
    }
}
