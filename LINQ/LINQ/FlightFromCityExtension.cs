using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class FlightFromCityExtension
    {
        public static IEnumerable<T> FlightFromCity<T>(this IEnumerable<T> flights, Func<T, bool> predicate)
        {
            var found = new List<T>();
            foreach (var flight in flights)
            {
                if (predicate(flight))
                    found.Add(flight);

            }
            return found;
        }
    }
}
