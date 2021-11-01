using Funkcje.Infrastructure;
using Funkcje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dane
            var programmers = new Employee[]
            {
                new Employee { EmployeeId = 1, FirstName = "Marcin", LastName = "Nowak"},
                new Employee { EmployeeId = 2, FirstName = "Tomek", LastName = "Kowal"},
                new Employee { EmployeeId = 3, FirstName = "Jacek", LastName = "Sobota"},
                new Employee { EmployeeId = 4, FirstName = "Adam", LastName = "Wrona"}
            };

            var drivers = new List<Employee>()
            {
                new Employee { EmployeeId = 5, FirstName = "Olek", LastName = "Sroka"},
                new Employee { EmployeeId = 6, FirstName = "Pawel", LastName = "Wrobel"},
                new Employee { EmployeeId = 7, FirstName = "Marek", LastName = "Piatek"}
            };
            #endregion Dane
            #region Enumerator
            //IEnumerator<Employee> enumerator = drivers.GetEnumerator();

            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.FirstName);
            //}
            #endregion Enumerator
            #region Metoda roz
            //var count = programmers.Count();
            //Console.WriteLine(count);

            //Console.WriteLine("Dodatkowe zadanie");
            //string word = "Annapurna";
            //int result = word.CountChars();
            //Console.WriteLine(@"Slowo: {0}, ilosc znaków: {1}", word, result);
            #endregion Metoda roz
            #region Lambda
            #region Metoda nazwana
            //foreach(var person in programmers.Where(RozpoczynaNaM))//<- Metoda nazwana
            //{
            //    Console.WriteLine(person.FirstName);
            //}
            #endregion Metoda nazwana
            #region Metoda anonimowa
            //foreach (var person in programmers.Where(
            //    delegate (Employee employee) { return employee.FirstName.StartsWith("M"); }))//<- Metoda anonimowa
            //{
            //    Console.WriteLine(person.FirstName);
            //}
            #endregion Metoda anonimowa
            #region Funkcja Lambda
            //foreach (var person in programmers.Where(x => x.FirstName.StartsWith("M")))//<- Lambda
            //{
            //    Console.WriteLine(person.FirstName);
            //}
            #endregion Funkcja Lambda
            #region Func
            //Func<int, int> Potegowanie = x => x * x;
            //Func<int, int, int> Dodawanie = (x, y) => x + y;
            //Console.WriteLine(@"Potegowanie: {0}", Potegowanie(2));
            //Console.WriteLine(@"Dodawanie: {0}", Dodawanie(2, 2));
            #endregion Func
            #region Action
            //Action<int> Wyswietl = x => Console.WriteLine(@"Action: {0}", x);
            //Wyswietl(Dodawanie(10, 22));
            #endregion Action
            #endregion Lambda

            foreach (var person in programmers
                .Where(e => e.FirstName.Length == 5)
                .OrderByDescending(e => e.FirstName))
            {
                Console.WriteLine(person.FirstName);
            }

            var querySyntax = from programmer in programmers
                              where programmer.FirstName.Length == 5
                              orderby programmer.FirstName descending
                              select programmer;

            foreach (var programmer in querySyntax)
            {
                Console.WriteLine(programmer.FirstName);
            }

            Console.ReadLine();
        }


        private static bool RozpoczynaNaM(Employee employee)
        {
            return employee.FirstName.StartsWith("M");
        }
    }
}
