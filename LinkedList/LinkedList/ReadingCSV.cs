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
        public string[] Reading()
        {
            Console.Write("Enter the name of CSV file to read: ");
            string name = Console.ReadLine();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = System.IO.Path.GetDirectoryName(path);
            string result = directory.Remove(directory.Length - 31) + name + ".csv";

            string[] File = System.IO.File.ReadAllLines(result);

            
            return File;
        }
    }
}
