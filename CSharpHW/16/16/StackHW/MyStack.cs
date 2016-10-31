using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHW
{
    class MyStack<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node NextNode { get; set; }
        }

        private Node _head;
        public int Count { get; private set; }
        public void Push(T item)
        {
            Node n = new Node();
            n.Data = item;
            n.NextNode = _head;
            _head = n;
            ++Count;
        }

        public T Pop()
        {
            T data = _head.Data;
            _head = _head.NextNode;
            --Count;
            return data;
        }

        public T Peek()
        {
            if (_head == null)
                throw new NullReferenceException();

            return _head.Data;
        }
    }
}
