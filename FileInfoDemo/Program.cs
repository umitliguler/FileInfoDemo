using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var filePath = @"c:\vidobu\cs_file.txt";

            FileInfo fi = new FileInfo(filePath);

            if (fi.Exists)
            {
                Console.WriteLine("CreationTime : {0}", fi.CreationTime);
                Console.WriteLine("DirectoryName : {0}", fi.DirectoryName);
                Console.WriteLine("FullName : {0}", fi.FullName);
                Console.WriteLine("Name : {0}", fi.Name);
                Console.WriteLine("Extension : {0}", fi.Extension);
            }

            Console.ReadKey();

        }
    }
}
