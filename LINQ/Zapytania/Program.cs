using System;
using System.Collections.Generic;
using System.Linq;
using Zapytania.Infrastructure;
using Zapytania.Models;

namespace Zapytania
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie { Title = "Siedem", Genre = "Thriller", Rating = 8.3f, Year = 1995},
                new Movie { Title = "Efekt motyla", Genre = "Thriller", Rating = 7.8f, Year = 2004},
                new Movie { Title = "127 godzin", Genre = "Dramat", Rating = 7.1f, Year = 2010},
                new Movie { Title = "Skazani na Shawshank", Genre = "Dramat", Rating = 8.7f, Year = 1994},
                new Movie { Title = "Zielona mila", Genre = "Dramat", Rating = 8.6f, Year = 1999},
                new Movie { Title = "Forrest Gump", Genre = "Komedia", Rating = 8.5f, Year = 1994},
                new Movie { Title = "Piękny umysł ", Genre = "Dramat", Rating = 8.3f, Year = 2001},
                new Movie { Title = "Gladiator", Genre = "Dramat", Rating = 8.1f, Year = 2000}
            };

            //var query = movies.Filtr(x => x.Year > 2002).Take(1);

            //var query = movies.Where(x => x.Year > 2002);

            //foreach (var result in query)
            //{
            //    Console.WriteLine(result.Title);
            //}

            var query = Enumerable.Empty<Movie>();

            try
            {
                query = movies.Filtr(x => x.Year > 2002);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

            Console.WriteLine("#################################");
            int count = query.Count();
            Console.WriteLine(count);

            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }

            Console.ReadKey();

        }
    }
}