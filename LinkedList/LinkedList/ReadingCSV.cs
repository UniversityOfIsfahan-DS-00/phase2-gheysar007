using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace LinkedList
{
    partial class Program
    {
        string FilePath;
        public string[] Reading()
        {
            Console.Write("Enter the name of CSV file to read: ");
            string FileName = Console.ReadLine();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = System.IO.Path.GetDirectoryName(path);
            FilePath = directory.Remove(directory.Length - 31) + FileName + ".csv";

            string[] File = System.IO.File.ReadAllLines(FilePath);

            
            return File;
        }
    }
}
