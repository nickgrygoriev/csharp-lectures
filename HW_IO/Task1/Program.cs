using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteToFile();
            ReadFromFile();
            Console.ReadKey();
        }

        static void WriteToFile()
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(@"NewFile.txt", false);
                Console.WriteLine("Input data for writing in file end press Enter:");
                string toFile = Console.ReadLine();
                sw.WriteLine(toFile);
                sw.WriteLine("AdditionalLine1");
                sw.WriteLine("AdditionalLine2");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            } 
        }

        static void ReadFromFile()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"NewFile.txt");
                string info;

                Console.WriteLine("Data from file:");
                while ((info = sr.ReadLine()) != null)
                {
                    Console.WriteLine(info);
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            } 
        }
    }
}
