using System;
using System.Collections.Generic;

namespace Zapytania.Infrastructure
{
    public static class MyLinq
    {
        public static IEnumerable<T> Filtr<T>(this IEnumerable<T> data, Func<T, bool> predicate)
        {
            foreach(var item in data)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }

    }
}
