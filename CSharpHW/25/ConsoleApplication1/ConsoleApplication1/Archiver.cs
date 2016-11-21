using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Archiver
    {
        int maxThreads = 4;
        volatile int numOfThreads = 0;
        private static object obj = new object(),
            obj2 = new object();
        public void ArchiveFiles(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] directories = dir.GetDirectories();
            int size = directories.Length - 1;

            Thread t = new Thread(new ParameterizedThreadStart(Archive));
            int i;
            lock(obj2)
            {
                if (numOfThreads < maxThreads)
                {
                    t.Start(directories[0]);
                    ++numOfThreads;
                    i = 1;
                }
                else
                {
                    i = 0;
                }

            }
        
            for (; i < directories.Length; ++i)
            {
                Archive(directories[i]);
            }
            Archive(dir);
            t.Join();
        }

        public static void Archive(object D)
        {

            lock (obj)
            {
                DirectoryInfo dir = (DirectoryInfo)D;
                DirectoryInfo[] directories = dir.GetDirectories();
                var allFiles = dir.GetFiles();
                var files = (from f in allFiles

                             where !f.Name.EndsWith(".zip") &&
                             (from d in directories
                              where d.Name == f.Name.DeleteExtension()
                              select d).Count() == 0
                             select f).ToArray();


                int lenght = files.Length;
                string dName, path;
                for (int i = 0; i < lenght; ++i)
                {
                    dName = files[i].Name.DeleteExtension();
                    path = string.Format(@"{0}\{1}\{2}", dir.FullName, dName, files[i].Name);
                    DirectoryInfo d = dir.CreateSubdirectory(dName);
                    File.Copy(files[i].FullName, path);

                    string filezip = d.FullName + ".zip";
                    if (!allFiles.ContainFile(filezip))
                    {
                        ZipFile.CreateFromDirectory(d.FullName, filezip);
                    }
                    d.Delete(true);
                }


                for (int i = 0; i < directories.Length; ++i)
                    Archive(directories[i]);
            }
        }
        public static void Extract(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            var directories = dir.GetDirectories();

            var files = from file in dir.GetFiles()
                        where file.Name.EndsWith(".zip")
                        select file;

            foreach (var file in files)
            {
                try
                {
                    ZipFile.ExtractToDirectory(file.FullName, dir.FullName);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Continue? y(Yes)/n(No)");
                    if (Console.ReadLine().ToLower() == "y")
                        return;
                    continue;
                }
            }
        }
    }
}

