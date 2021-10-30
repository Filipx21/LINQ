using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ.Przyklady
{
    public class DaneKatalogow
    {
        private const string PATH = @"c:\windows";

        public void Start()
        {
            ShowBigFileWithoutLinq(PATH);
            Console.WriteLine("************************************");
            ShowBigFileWithLinqQuerySyntax(PATH);
        }

        private void ShowBigFileWithLinqQuerySyntax(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;
            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name,-24} : {file.Length,1:N0}");
            }
        }

        private void ShowBigFileWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();

            Array.Sort(files, new FileInfoComparer());

            for (var i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name,-24} : {file.Length,1:N0}");
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
