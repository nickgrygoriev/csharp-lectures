using System;
using System.Threading;

namespace Task1
{
    class Program
    {
        private static int windowHeight = 30;
        private static int windowWidth = 80;
        private static object cs = new object();
        private static Random r = new Random();

        static void Main(string[] args)
        {
            Console.SetWindowSize(windowWidth, windowHeight);
            Thread[] chains = new Thread[windowWidth];
            for (int i = 0; i < chains.Length; i++)
            {
                ParameterizedThreadStart p = new ParameterizedThreadStart(Chain);
                chains[i] = new Thread(p);
                chains[i].Start(i);
            }
        }

        static void Chain(object column)
        {
            if ((int)column % 2 == 0)
            {
                Thread.Sleep(r.Next(5000));
            }

            char symbol;
            while (true)
            {
                int chainLength = r.Next(10);
                int currentChainLength = 0;
                int chainStart = 0;
                int height = windowHeight + chainLength;

                while (height > 0)
                {
                    height--;
                    if (currentChainLength < chainLength)
                    {
                        symbol = (char)r.Next(48, 90);
                        lock (cs)
                        {
                            Console.SetCursorPosition((int)column, 0);
                            switch (currentChainLength)
                            {
                                case 0:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    break;
                            }
                            Console.Write(symbol);
                        }
                        currentChainLength++;
                    }
                    else
                    {
                        symbol = ' ';
                        lock (cs)
                        {
                            Console.SetCursorPosition((int)column, chainStart);
                            Console.Write(symbol);
                        }
                        chainStart++;
                    }

                    for (int i = chainStart; i < chainStart + currentChainLength; i++) 
                    {
                        if (i < windowHeight)
                        {
                            symbol = (char)r.Next(48, 90);
                            lock (cs)
                            {
                                Console.SetCursorPosition((int)column, i);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                if (i == chainStart + currentChainLength - 1 && i != windowHeight)
                                    Console.ForegroundColor = ConsoleColor.White;
                                if (i == chainStart + currentChainLength - 2 && i != windowHeight)
                                    Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(symbol);
                            }
                        }
                    }
                    Thread.Sleep(r.Next(500));
                }
            }
        }
    }
}
