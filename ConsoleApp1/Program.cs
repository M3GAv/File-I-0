using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInfo();
            string path = @"D:\infoFile.txt";
            /*if (File.Exists(path))
            {                                        <- check if file exists
                Console.WriteLine("File exsist!");
            }*/

            /*string[] lines;
             lines = File.ReadAllLines(path);
             Console.WriteLine(lines[0]);           <- reading specific lines
             Console.WriteLine(lines[1]);*/

            /*string lines;
            lines = File.ReadAllText(path);     <- read all lines 
            Console.WriteLine(lines);*/

            /*string path1 = @"D:\example.txt";
            string copypath = @"D:\ExampleNew.txt";     <- copy from path1 to copypath
            File.Copy(path1,copypath);*/

            /*string path1 = @"D:\Example.txt";   <- delete file
            File.Delete(path1);*/
               
        }

        static void AppInfo()
        {
            string appName = "File I/0";
            string appVersion = "0.1";
            string appAuthor = "Mateusz Celka";
            Console.WriteLine("{0} version: {1} by {2}",appName,appVersion,appAuthor);
        }
    }
}
