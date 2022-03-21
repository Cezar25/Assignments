using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Flight
    {
        public Flight(string departure, string destination, int flightID, bool hasBusinessClass)
        {
            Departure = departure;
            Destination = destination;
            FlightID = flightID;
            HasBusinessClass = hasBusinessClass;
        }

        public string Departure { get; set; }
        public string Destination { get; set; }
        public int FlightID { get; set; }
        public bool HasBusinessClass { get; set; }

        public override string ToString()
        {
            return $"Flight leaving from {Departure} heading to {Destination} with the ID of {FlightID} and business class: {HasBusinessClass}";
        }

        
        
    }
}
