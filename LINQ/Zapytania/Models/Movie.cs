using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapytania.Models
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public float Rating { get; set; }

        private int _Year;
        public int Year {
            get 
            {
                throw new Exception("Error");
                Console.WriteLine($"Zwraca {_Year} i {Title}");
                return _Year;  
            }
            set { _Year = value; } 
        }
    }
}
