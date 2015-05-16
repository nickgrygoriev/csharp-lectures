using System;
using System.IO;
using System.IO.Compression;

namespace Task2
{
    class Program
    {
        static Boolean isFound;

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            string fileName = "InternshipFileForSearch.txt";
            Console.WriteLine("Please wait for file searching");
            FileSearch(dir, fileName);
            if (!isFound)
            {
                Console.WriteLine("File was not found");
            }
            Console.ReadKey();
        }

        static void FileSearch(DirectoryInfo dir, string fileName)
        {
            FileInfo[] files;
            try
            {
                files = dir.GetFiles();
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }

            foreach (FileInfo file in files)
            {
                if (file.Name.Equals(fileName))
                {
                    isFound = true;
                    Console.WriteLine("File was found in " + file.FullName);
                    FileStream fs = file.OpenRead();
                    Console.WriteLine();
                    ReadFromFile(fs);
                    Console.WriteLine();
                    Compress(file);
                    fs.Close();
                    return;
                }
            }

            DirectoryInfo[] directories = dir.GetDirectories();
            foreach (DirectoryInfo inDir in directories)
            {
                FileSearch(inDir, fileName);
                if (isFound) return;
            }
        }

        static void ReadFromFile(FileStream fs)
        {
            Console.WriteLine("File contents:");
            string str;
            StreamReader sr = new StreamReader(fs);
            while ((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
            sr.Close();
        }

        static void Compress(FileInfo fileToCompress)
        {
            using (FileStream originalFileStream = fileToCompress.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                        CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
                FileInfo info = new FileInfo(fileToCompress.FullName + ".gz");
                Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                fileToCompress.Name, fileToCompress.Length.ToString(), info.Length.ToString());
            }
        }
    }
}
