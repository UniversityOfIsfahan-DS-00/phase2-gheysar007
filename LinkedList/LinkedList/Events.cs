using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    partial class Program
    {
        public void Insert(int row, int col, int value)
        {
            RowList[row].Insert(value, col);
        }
        public void Delete(int row, int col)
        {
            RowList[row].Delete(col);
        }
        public void Search(int value)
        {
            bool IsFound = false;
            int RowNum = 0;
            foreach (var item in RowList)
            {
                int ColNum = item.Search(value);
                if (ColNum != -1)
                {
                    IsFound = true;
                    Console.WriteLine($"The value is in the list, Row: {RowNum} Column: {ColNum}");
                    break;
                }
                RowNum++;
            }
            if (!IsFound)
            {
                Console.WriteLine("The value is not in the list");
            }
        }
        public void Update(int row, int col, int value)
        {
            RowList[row].Update(value, col);
        }
        public void Print(Boolean printType)
        {
            foreach (var item in RowList)
            {
                item.Print(printType);
            }
            
        }
    }
}
