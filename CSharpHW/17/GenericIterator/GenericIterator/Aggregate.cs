﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIterator
{
    abstract class Aggregate<T>
    {
        public abstract Iterator<T> CreateIterator();
    }
}
