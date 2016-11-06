using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIterator
{
    class ConcreteAggregate<T> : Aggregate<T>
    {
        private List<T> _collection = new List<T>();
        public override Iterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public int Count
        {
            get
            {
                return _collection.Count;
            }
        }

        public T this[int index]
        {
            get
            {
                return _collection[index];
            }
            set
            {
                _collection.Insert(index, value);
            }
        }

    }
}
