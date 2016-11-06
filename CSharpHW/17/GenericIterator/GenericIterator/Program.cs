using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate<char> aggregate = new ConcreteAggregate<char>();
            aggregate[0] = 'A';
            aggregate[1] = 'B';
            aggregate[2] = 'C';
            aggregate[3] = 'D';

            var iterator = aggregate.CreateIterator();

            Console.WriteLine(iterator.First());
            while(iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
