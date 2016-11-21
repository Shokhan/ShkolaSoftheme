using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextReplace
{
    class FileEditor
    {
        int maxThreads = 4;
        volatile int _threads = 0;

        string[] _extensions = { ".txt", ".doc", ".html", ".cs", ".cpp" };
        public void Replace(string path, string target, string placeholder)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir == null)
                return;

            var files = from file in dir.GetFiles()
                        where CheckExtension(file.Name)
                        select file;

            EditFile(files, target, placeholder);

            var directories = dir.GetDirectories();
            foreach (var d in directories)
            {
                Replace(d.FullName, target, placeholder);
            }

        }

        private void EditFile(IEnumerable<FileInfo> files, string target, string placeholder)
        {
            foreach (var f in files)
            {
               
            }
        }

        private bool CheckExtension(string str)
        {
            foreach (var ext in _extensions)
            {
                if (str.EndsWith(ext))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
