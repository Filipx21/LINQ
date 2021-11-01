using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje.Infrastructure
{
    public static class MyFunctionLinq
    {
        public static int Count<T>(this IEnumerable<T> collection)
        {
            var counter = 0;

            foreach(var element in collection)
            {
                counter++;
            }

            return counter;
        }

        public static int CountChars(this string word)
        {
            return word.ToArray().Count();
        }
    }
}
