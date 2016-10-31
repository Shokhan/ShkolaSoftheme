using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueHW
{
    public class MyQueue<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node NextNode { get; set; }
        }

        private Node _head = null;
        public int Count { get; private set; }
        
        public void Enqueue(T item)
        {
            if(_head == null)
            {
                _head = new Node();
                _head.Data = item;
                _head.NextNode = null;
            }
            else
            {
                Node n = _head;
                while (n.NextNode != null)
                    n = n.NextNode;

                n.NextNode = new Node();
                n = n.NextNode;
                n.Data = item;
                n.NextNode = null;
            }
            ++Count;
        }

        public T Deque()
        {
            if (_head == null)
                throw new NullReferenceException();

            T data = _head.Data;
            _head = _head.NextNode;
            --Count;
            return data;
        }

        public T Peak()
        {
            return _head.Data;
        }
    }
}
