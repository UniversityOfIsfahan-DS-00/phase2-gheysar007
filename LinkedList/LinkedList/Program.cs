using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Program Sample = new Program();
            Sample.SwitchEvents(Sample.Introduction(Sample.Reading()));

            Console.ReadKey();
        }
    }
}
