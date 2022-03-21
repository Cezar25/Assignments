using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Airport
    {
        public Airport(string name, int numberOfGates, IEnumerable<Flight> flights)
        {
            Name = name;
            NumberOfGates = numberOfGates;
            Flights = flights;
        }

        public string Name { get; set; }
        public int NumberOfGates { get; set; }
        public IEnumerable<Flight> Flights { get; set; }

        public void Print()
        {
            Console.WriteLine($"Airport named {Name} having {NumberOfGates} gates and the following flights: ");
            foreach (var flight in Flights)
            {
                Console.WriteLine(flight.ToString());
            }
        }

    }
}
