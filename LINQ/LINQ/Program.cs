using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();

            //Method2();

            //Method3();

            //Below we test the LINQ system methods
            //LINQMethods.Filtering();

            //Below we test the projection methods
            //LINQMethods.Projection();

            //Below we test the joins methods
            //LINQMethods.Joins();

            //Below we test the grouping methods
            //LINQMethods.Grouping();

            //Below we test the ordering methods
            //LINQMethods.Ordering();

            //Below we test the set operators methods
            //LINQMethods.SetOperators();

            //Below we test the convertion methods
            //LINQMethods.Convertion();

            //Below we test the element operators
            //LINQMethods.ElementOperators();

            //Below we test the aggregation methods
            //LINQMethods.Aggregation();

            //Below we test the quantifiers
            //LINQMethods.Quantifiers();

            //Below we test the generation methods
            //LINQMethods.Generation();

            var list = new List<string>();
            list.Add("aaaa");
            list.Add("bb");
            list.Add("ccc");



            

        }

        //Extension method number 1 without using yield return
        public static void Method1()
        {
            var flights = Default.GetDefaultFlights1();
            Console.WriteLine("All the fligths are: ");
            Default.Print(flights);

            Console.WriteLine("Type in the departure city you are looking for: ");
            var searchedCity = Console.ReadLine();

            Console.WriteLine($"The flights leaving from {searchedCity} are:");
            var foundFlights = flights.FlightFromCity(city => city.Departure == searchedCity);
            Default.Print(foundFlights);
        }

        //Extension method number 2 using yield return
        public static void Method2()
        {
            var airports = Default.GetDefaultAirports();
            Console.WriteLine("All the airports are: ");
            foreach (var airport in airports)
            {
                airport.Print();
            }
            Console.WriteLine("Type in the number of gates: ");
            int number = Convert.ToInt32(Console.ReadLine());

            var foundAirports = airports.NumberOfGatesGreaterThan(airport => airport.NumberOfGates > number);
            Console.WriteLine("The found airports are:");

            foreach (var airport in foundAirports)
            {
                airport.Print();
            }
        }

        //Small problem with this method... I will ask you to help me with it :)
        public static void Method3()
        {
            var airport1 = new Airport("Heathrow", 50,Default.GetDefaultFlights1());
            var airport2 = new Airport("Henri Coanda", 15, Default.GetDefaultFlights2());
            var airport3 = new Airport("NY Aiport", 100, Default.GetDefaultFlights3());
            Console.WriteLine("All the airports are: ");
            airport1.Print();
            airport2.Print();
            airport3.Print();

            Console.WriteLine("Type in the boolean value for HasBusinessClass:(true or false) ");
            var boolean = bool.Parse(Console.ReadLine());

            var found1 = airport1.Flights.FlightsHavingBusinessClass(flight => flight.HasBusinessClass == boolean);
            var found2 = airport1.Flights.FlightsHavingBusinessClass(flight => flight.HasBusinessClass == boolean);
            var found3 = airport1.Flights.FlightsHavingBusinessClass(flight => flight.HasBusinessClass == boolean);

            Console.WriteLine("The found flights are: ");
            Default.Print(found1);
            Default.Print(found2);
            Default.Print(found3);
        }
        
    }
}
