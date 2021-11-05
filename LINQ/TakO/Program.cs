using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace TakO
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new GenerateValue();
            var inputs = input.InputData(5);
            
            Console.WriteLine("Posortowana lista");
            foreach (var i in inputs.OrderByDescending(x => x.Weight))
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine($"Najwiekszy element: {inputs.OrderByDescending(x => x.Weight).First()}");
            Console.ReadKey();
        }
    }

    public interface IInput
    {
        List<Input> InputData(int loop);
    }

    public class GenerateValue : IInput
    {

        public List<Input> InputData(int loop)
        {
            List<Input> data = new List<Input>();

            for (var x = 0; x < loop; x++)
            {
                try
                {
                    Console.Write("Podaj produkt z wagą: ");
                    var consoleInput = Console.ReadLine();
                    var input = FetchInput(consoleInput);
                    data.Add(input);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    --x;
                }
                Thread.Sleep(156);
            }

            return data;
        }

        private Input FetchInput(string consoleInput)
        {
            var elements = consoleInput.Split(' ');

            var unit = CheckUnit(elements[1]);

            return new Input()
            {
                Weight = CheckWeight(elements[0], unit),
                Unit = "kg",
                Name = CheckName(elements[2])
            };
        }

        private string CheckName(string consoleName)
        {
            return consoleName;
        }

        private string CheckUnit(string consoleUnit)
        {
            string[] units = new string[] { "kg", "dag", "g", "mg" };

            foreach(var unit in units)
            {
                if (unit.Equals(consoleUnit.ToLower()))
                    return consoleUnit.ToLower();
            }
            throw new ArgumentException("Error: Invalid unit");
        }

        private double CheckWeight(string consoleWeight, string unit)
        {
            var regex = new Regex(@"\d");

            if (!regex.IsMatch(consoleWeight))
                throw new ArgumentException("Error: Invalid weight");

            var weight = Convert.ToDouble(consoleWeight);

            if (unit.Equals("kg"))
                return weight;
            else if (unit.Equals("dag"))
                return weight * 0.01;
            else if (unit.Equals("g"))
                return weight * 0.001;
            else if (unit.Equals("mg"))
                return weight * 0.000001;

            throw new ArgumentException("Error: Invalid weight");
        }
    }

    public class Input
    {
        public double Weight { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2}", Weight, Unit, Name);
        }
    }
}
