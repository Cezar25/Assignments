﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class FlightsHavingBusinessClassExtension
    {
        public static IEnumerable<T> FlightsHavingBusinessClass<T>(this IEnumerable<T> airports, Func<T, bool> predicate)
        {
            foreach (var airport in airports)
            {
                if (predicate(airport))
                    yield return airport;
            }
        }
    }
}
