using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    partial class Program
    {
        Matrix[] RowList;

        public void SwitchEvents(Matrix[] linklist)
        {
            RowList = linklist;

            Console.WriteLine("How can I help you?");
            Console.WriteLine("Enter 0 to insert new element");
            Console.WriteLine("Enter 1 to delete an element");
            Console.WriteLine("Enter 2 to search for an element");
            Console.WriteLine("Enter 3 to update an element");
            Console.WriteLine("Enter 4 to print");
            Console.WriteLine("Enter 5 to Save all");
            Console.WriteLine("Enter * to Exit");

            var KP = Console.ReadKey();

            switch (KP.Key)
            {
                case ConsoleKey.NumPad0:
                    Console.Clear();
                    Console.WriteLine("Enter Row: ");
                    int Row = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter column: ");
                    int Column = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter Value");
                    int Value = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Insert(Row, Column, Value);
                    break;

                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.WriteLine("Enter Row: ");
                    Row = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter column: ");
                    Column = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Delete(Row, Column);
                    break;

                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Console.WriteLine("Enter Value");
                    Value = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Search(Value);
                    break;
                default:
                    break;
            }

        }
    }
}
