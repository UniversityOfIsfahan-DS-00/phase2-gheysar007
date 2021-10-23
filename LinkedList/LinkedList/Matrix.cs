using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Matrix
    {
        public class Node
        {
            private int _value;
            private int _columnIndex;
            private Node _next;
            public Node(int value, int coumnIndex, Node next)
            {
                _value = value;
                _columnIndex = coumnIndex;
                _next = next;
            }

            public int Value { get { return _value; } }

            public int ColumnIndex { get { return _columnIndex; } }

            public Node Next { get { return _next; } set { _next = value; } }
        }

        private Node _head = null;
        private Node _tail = null;
        private int _size = 0;

        public int Size { get { return _size; } }
        public void AddFirst(int value, int colIndex)
        {
            _head = new Node(value, colIndex, _head);
            if (Size == 0)
            {
                _tail = _head;
            }
            _size++;
        }
        public void AddLast(int value, int colIndex)
        {
            Node newest = new Node(value, colIndex, null);
            if (Size == 0)
            {
                _head = newest;
            }
            else
            {
                _tail.Next = newest;    
            }
            _tail = newest;
            _size++;
        }
        public void Insert(int Value, int Column)
        {
            if (Column == 0)
            {
                AddFirst(Value, Column);
            }
            else
            {
                Node search = _head;
                int index = 1;
                while (index++ != Column)
                {
                    search = search.Next;
                }
                Node newest = new Node(Value, Column, search.Next);
                if (newest.Next == null)
                {
                    _tail = newest;
                }
                search.Next = newest;
                _size++;
            }
            
        }
    }
}
