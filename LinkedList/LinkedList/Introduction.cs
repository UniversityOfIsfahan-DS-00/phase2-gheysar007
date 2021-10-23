using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    partial class Program
    {
        public Matrix[] Introduction(string[] Input)
        {
            Matrix[] RowList = new Matrix[Input.Length];
            for (int i = 0; i < Input.Length; i++)
            {
                RowList[i] = new Matrix();
            }

            string[] SingleRow;
            int NumbersOfRow = 0;
            foreach (var item in Input)
            {
                SingleRow = item.Split(',');
                int Index = 0;
                foreach (var i in SingleRow)
                {

                    if (i != "0")
                    {
                        RowList[NumbersOfRow].AddLast(int.Parse(i), Index++);
                    }
                }
                NumbersOfRow++;
            }

            return RowList;
        }
    }
}
