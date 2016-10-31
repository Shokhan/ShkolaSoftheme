using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();
            Console.WriteLine("Enque: 5, 4, 3, 2, 1");
            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            Console.WriteLine("Peak: {0}", queue.Peak());

            Console.WriteLine("Deque:");

            int size = queue.Count;
            for (int i = 0; i < size; ++i)
                Console.Write("{0} ", queue.Deque());
            Console.WriteLine();
        }
    }
}
