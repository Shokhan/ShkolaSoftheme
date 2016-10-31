using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHW
{
    class MyDictionary<TKey, TValue>
        where TKey : class
        where TValue: class
    {
        private class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Next { get; set; }
        }

        private Node _head;

        public int Count { get; private set; }

        public void Add(TKey key, TValue value)
        {
            
            if(_head == null)
            {
                _head = new Node();
                _head.Next = null;
                _head.Key = key;
                _head.Value = value;
            }

            Node n = _head;
            while (n.Next != null)
            {
                if (n.Key == key)
                    break;
                n = n.Next;
            }

            if (n != null && n.Key == key)
            {
                n.Value = value;               
            }
            else
            {
                n.Next = new Node();
                n = n.Next;
                n.Key = key;
                n.Value = value;
            }
        }

        public TValue Find(TKey key)
        {
            Node n = _head;
            while(n != null)
            {
                if (n.Key == key)
                    return n.Value;
                n = n.Next;
            }

            return default(TValue);
        }
    }
}
