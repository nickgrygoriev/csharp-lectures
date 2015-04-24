using System;

namespace Task2
{
    public delegate int RandomDelegate();
    public delegate int DelegateArray(RandomDelegate[] randArray);

    class Program
    {
        static void Main(string[] args)
        {
            int delegatesNum = 10;
            Random r = new Random();
            RandomDelegate[] rand = new RandomDelegate[delegatesNum];

            for (int i = 0; i < delegatesNum; i++)
            {
                rand[i] = delegate()
                {
                    return r.Next(100);
                };
            }

            
            DelegateArray delArray = delegate(RandomDelegate[] randArray)
            {
                int sum = 0;

                for (int i = 0; i < delegatesNum; i++)
                {
                    sum += randArray[i]();
                }

                return sum/delegatesNum;
            };

            Console.WriteLine("Average value: {0}", delArray(rand));
            Console.ReadKey();
        }
    }
}