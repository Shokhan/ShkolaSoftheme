using System.IO;

namespace ConsoleApplication1
{
    public static class Extensions
    {
        public static string DeleteExtension(this string str)
        {
            int index = str.IndexOf('.');
            return str.Substring(0, index);
        }

        public static bool ContainFile(this FileInfo[] files, string path)
        {
            foreach(var file in files)
            {
                if (file.FullName == path)
                    return true;
            }

            return false;
        }
    }
}
