using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandleHW
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\File";
            FileHandle h1 = OpenForRead(path);

            Console.WriteLine("OpenForRead");
            h1.Read();
            h1.Write();
            Console.WriteLine("FileInfo:\n {0}\n", h1.ToString());

            FileHandle h2 = OpenForWrite(path);

            Console.WriteLine("OpenForRead");
            h2.Read();
            h2.Write();
            Console.WriteLine("FileInfo:\n {0}\n", h2.ToString());

            FileHandle h3 = OpenFile(path, (FileHandle.FileAccess.Write | FileHandle.FileAccess.Read));

            Console.WriteLine("OpenForRead");
            h3.Read();
            h3.Write();
            Console.WriteLine("FileInfo:\n {0}\n", h3.ToString());
        }

        private static FileHandle Open(string path)
        {
            string temp = string.Empty;
            int i = path.Length - 1;
            while (path[i] != '\\')
                --i;

            for(; i < path.Length; ++i)
                temp += path[i];

            FileHandle handle = new FileHandle();
            handle.FileName = temp;
            handle.FilePath = path;

            Random r = new Random();
            handle.FileSize = r.Next();

            return handle;
        }

        public static FileHandle OpenForRead(string path)
        {
            FileHandle handle = Open(path);
            handle.fileAccess = FileHandle.FileAccess.Read;
            return handle;
        }

        public static FileHandle OpenForWrite(string path)
        {
            FileHandle handle = Open(path);
            handle.fileAccess = FileHandle.FileAccess.Write;
            return handle;
        }

        public static FileHandle OpenFile(string path, FileHandle.FileAccess fAccessKeys)
        {
            FileHandle handle = Open(path);
            handle.fileAccess = fAccessKeys;
            return handle;
        }
    }
}
