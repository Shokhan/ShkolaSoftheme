using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIterator
{
    public abstract class Iterator<T>
    {
        public abstract T First();
        public abstract T Next();
        public abstract bool IsDone();
        public abstract T Current();
    }
}
