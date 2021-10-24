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

            Console.Clear();
            Console.WriteLine("Enter 0 to insert new element.");
            Console.WriteLine("Enter 1 to delete an element.");
            Console.WriteLine("Enter 2 to search for an element.");
            Console.WriteLine("Enter 3 to update an element.");
            Console.WriteLine("Enter 4 to print.");
            Console.WriteLine("Enter 5 to Save all.");
            Console.WriteLine("Enter * to Exit.");

            var KP = Console.ReadKey();

            int Row;
            int Column;
            int Value;
            switch (KP.Key)
            {
                case ConsoleKey.NumPad0:
                    Console.Clear();
                    Console.WriteLine("Enter Row: ");
                    Row = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter column: ");
                    Column = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter Value");
                    Value = int.Parse(Console.ReadLine());
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

                case ConsoleKey.NumPad3:
                    Console.Clear();
                    Console.WriteLine("Enter Row: ");
                    Row = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter column: ");
                    Column = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter Value");
                    Value = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Update(Row, Column, Value);
                    break;

                case ConsoleKey.NumPad4:
                    Console.Clear();
                    Console.WriteLine("Enter 0 to print the matrix in its usual form.");
                    Console.WriteLine("Enter 1 to print the matrix in short form.");
                    KP = Console.ReadKey();
                    Boolean PrintType = KP.Key != ConsoleKey.NumPad0;
                    Console.Clear();
                    Print(PrintType);
                    break;

                case ConsoleKey.NumPad5:
                    Console.Clear();
                    save_file();
                    break;

                default:
                    break;
            }

        }
    }
}
