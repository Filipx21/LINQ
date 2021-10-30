using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Przyklady
{
    public class DaneKatalogow
    {
        private const string PATH = @"c:\windows";

        public void Start()
        {
            ShowBigFileWithoutLinq(PATH);

        }

        private void ShowBigFileWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();

            Array.Sort(files, new FileInfoComparer());

            for(var i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name, -24} : {file.Length, 1:N0}");
            }
        }
    }

    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
