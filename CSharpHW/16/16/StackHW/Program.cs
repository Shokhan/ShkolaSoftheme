using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Push: 1, 2, 3, 4");
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine("Peek: {0}", stack.Peek());

            Console.Write("Pop: ");
            int size = stack.Count;
            for (int i = 0; i < size; ++i)
                Console.Write("{0} ", stack.Pop());
            Console.WriteLine();
        }
    }
}
