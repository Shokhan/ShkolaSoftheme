using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandleHW
{
    struct FileHandle
    {
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string FilePath { get; set; }

        public FileAccess fileAccess { get; set; }

        [Flags]
        public enum FileAccess : byte { Read = 0x01, Write = 0x02 };

        public void Read()
        {
            if ((fileAccess & FileAccess.Read) != 0)
                Console.WriteLine("Read success.");
            else
                Console.WriteLine("Read is not allowed.");
        }

        public void Write()
        {
            if ((fileAccess & FileAccess.Write) != 0)
                Console.WriteLine("Write success.");
            else
                Console.WriteLine("Write is not allowed.");
        }

        public override string ToString()
        {
            string str = "File Access: ";
            if ((fileAccess & FileAccess.Read) != 0)
                str += "Read ";
            if ((fileAccess & FileAccess.Write) != 0)
                str += "Write";
                return string.Format("Filename: {0}\nFilePath: {1}\nFileSize: {2}\n {3} ",
                    FileName, FilePath, FileSize.ToString(), str);
        }
    }
}
