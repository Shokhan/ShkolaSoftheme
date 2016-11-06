using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIterator
{
    class ConcreteIterator<T> : Iterator<T>
    {
        private readonly ConcreteAggregate<T> _aggreagate;
        private int _iter = 0;
        public ConcreteIterator(ConcreteAggregate<T> ag)
        {
            _aggreagate = ag;
        }

        public override T Current()
        {
            if(_iter < _aggreagate.Count-1)
                return _aggreagate[_iter];

            return default(T);
        }

        public override T First()
        {
            return _aggreagate[0];
        }

        public override bool IsDone()
        {
            return _aggreagate.Count-1 > _iter;
        }

        public override T Next()
        {
            return _aggreagate[++_iter];
        }
    }
}
