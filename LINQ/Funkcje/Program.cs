using Funkcje.Infrastructure;
using Funkcje.Models;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> programmers = new Employee[]
            {
                new Employee { EmployeeId = 1, FirstName = "Marcin", LastName = "Nowak"},
                new Employee { EmployeeId = 2, FirstName = "Tomek", LastName = "Kowal"},
                new Employee { EmployeeId = 3, FirstName = "Jacek", LastName = "Sobota"},
                new Employee { EmployeeId = 4, FirstName = "Adam", LastName = "Wrona"}
            };

            IEnumerable<Employee> drivers = new List<Employee>()
            {
                new Employee { EmployeeId = 5, FirstName = "Olek", LastName = "Sroka"},
                new Employee { EmployeeId = 6, FirstName = "Pawel", LastName = "Wrobel"},
                new Employee { EmployeeId = 7, FirstName = "Marek", LastName = "Piatek"}
            };

            var count = programmers.Count();
            Console.WriteLine(count);

            IEnumerator<Employee> enumerator = drivers.GetEnumerator();

            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.FirstName);
            }

            Console.WriteLine("Dodatkowe zadanie");
            string word = "Annapurna";
            int result = word.CountChars();
            Console.WriteLine(@"Slowo: {0}, ilosc znaków: {1}", word, result);



            Console.ReadLine();
        }
    }
}
