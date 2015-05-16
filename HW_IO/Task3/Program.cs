using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input word to replace:");
            string wordToReplace = Console.ReadLine(); //wordToReplace
            Console.WriteLine("Input new word:");
            string newWord = Console.ReadLine(); //etalon

            DirectoryInfo dir = new DirectoryInfo(@"..\..\RootDir");
            Replace(wordToReplace, newWord, dir);
            Console.WriteLine("Success");
            Console.ReadKey();
        }

        static void Replace(string wordToReplace, string newWord, DirectoryInfo dir)
        {
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                StreamReader sr = file.OpenText();
                string content = sr.ReadToEnd();
                sr.Close();

                content = content.Replace(wordToReplace, newWord);

                StreamWriter sw = new StreamWriter(file.FullName, false);
                sw.Write(content);
                sw.Close();
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo nestedDir in dirs)
            {
                Replace(wordToReplace, newWord, nestedDir);
            }
        }
    }
}
