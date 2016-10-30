using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class MyList<T>  
        where T : IComparable
    {
        private class Node
        {
            public T Val { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
        }

        private Node Head = null;
        private Node Tail = null;

        public int Size
        {
            get
            {
                int i = 0;
                Node n = Head;
                while (n != null)
                {
                    n = n.Next;
                    ++i;
                }
                return i;
            }
        }

        public void Add(T item)
        {
            Node temp = new Node();
            temp.Val = item;

            if (Tail == null)
            {
                temp.Next = null;
                temp.Previous = null;
                Head = temp;
                Tail = temp;
            }
            else
            {
                temp.Previous = Tail;
                Tail.Next = temp;
                Tail = temp;
            }
        }

        public bool Delete(T item)
        {
            Node n = Head;

            while (n != null)
            {
                if(n.Val.CompareTo(item) == 0)
                {
                    if (n != Head)
                        (n.Previous).Next = n.Next;
                    else
                        Head = n.Next;

                    if(n.Next != null)
                        (n.Next).Previous = n.Previous;
                    return true;
                }

                n = n.Next;
            }

            return false;
        }

        public bool IsAvalable(T item)
        {
            Node n = Head;
            while (n != null)
                if (n.Val.CompareTo(item) == 0)
                    return true;
            return false;
        }

        public T[] ToArray()
        {
            int size = Size;
            T[] arr = new T[size];
            Node n = Head;

            for(int i = 0; i < size; ++i)
            {
                arr[i] = n.Val;
                n = n.Next;
            }

            return arr;
        }

        public void Show()
        {
            Node n = Head;
            while(n != null)
            {
                Console.Write("{0} ", n.Val);
                n = n.Next;
            }

            Console.WriteLine();
        }
    }
}
