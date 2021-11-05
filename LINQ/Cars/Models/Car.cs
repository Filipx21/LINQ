using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    class Car
    {
        public int Year { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public double Capacity { get; set; }
        public int NumberOfCylinders { get; set; }
        public int BurningCity { get; set; }
        public int BurningHighway { get; set; }
        public int BurningMixed{ get; set; }

    }
}
