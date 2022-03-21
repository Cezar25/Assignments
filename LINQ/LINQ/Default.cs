using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Default
    {
        public static IEnumerable<Flight> GetDefaultFlights1()
        {
            return new List<Flight>
            {
                new Flight("Timisoara", "Bucuresti", 1234, true),
                new Flight("Berlin", "Madrid", 5555, true),
                new Flight("London", "LA", 7777, false),
                new Flight("Moscow", "Stuttgart", 3456, false),
                new Flight("Alabama", "NY", 9999, true)
            };
        }
        public static IEnumerable<Flight> GetDefaultFlights2()
        {
            return new List<Flight>
            {
                new Flight("Miami", "Bucuresti", 1234, true),
                new Flight("Berlin", "Timisoara", 5555, false),
                new Flight("London", "Cape Town", 7777, true),
                new Flight("Moscow", "Munchen", 3456, false),
                new Flight("Toronto", "NY", 9999, true)
            };
        }
        public static IEnumerable<Flight> GetDefaultFlights3()
        {
            return new List<Flight>
            {
                new Flight("Timisoara", "Iasi", 1234, false),
                new Flight("Barcelona", "Madrid", 5555, true),
                new Flight("New Port", "LA", 7777, false),
                new Flight("Venice", "Stuttgart", 3456, true),
                new Flight("Alabama", "Rio", 9999, true)
            };
        }

        public static void Print<T>(IEnumerable<T> Things)
        {
            foreach (var thing in Things)
            {
                Console.WriteLine(thing.ToString());
            }
        }

        public static IEnumerable<Airport> GetDefaultAirports()
        {
            return new List<Airport>
            {
                new Airport("Heathrow", 50, GetDefaultFlights1()),
                new Airport("Henri Coanda", 15, GetDefaultFlights2()),
                new Airport("NY Aiport", 100, GetDefaultFlights3())
            };
        }
    }
}
