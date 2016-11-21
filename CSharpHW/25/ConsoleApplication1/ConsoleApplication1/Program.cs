using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            while (input > 2 && input < 1)
            {
                Console.WriteLine("1.Archive.\n2.Extract.");
                input = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("InputPath:");
            string path = (Console.ReadLine());

            Archiver arc = new Archiver();
            switch (input)
            {
                case 1:
                    arc.ArchiveFiles(path);
                    break;
                case 2:
                    Archiver.Extract(path);
                    break;
            }

        }
    }
}
