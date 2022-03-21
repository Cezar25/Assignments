using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class LINQMethods
    {
        public static void Print<T>(IEnumerable<T> things)
        {
            Console.WriteLine();
            foreach (var thing in things)
            {
                Console.Write($"{thing} ");
            }
            Console.WriteLine();
        }
        public static void Filtering()
        {
            //Where() method
            var numbers = new int[]{ 1, 1, 2, 3, 4, 5, 6 , 6};

            var filtered = numbers.Where(x => x % 2 == 0);
            Print(filtered);

            //Take() method
            var filtered2 = numbers.Take(3);
            Print(filtered2);

            //Take() method
            var filtered3 = numbers.Skip(3);
            Print(filtered3);

            //Takewhile() method
            var filtered4 = numbers.TakeWhile(x => x % 2 !=0);
            Print(filtered4);

            //SkipWhile() method
            var filtered5 = numbers.TakeWhile(x => x < 3);
            Print(filtered5);

            //Distinct() method
            var filtered6 = numbers.Distinct();
            Print(filtered6);
        }

        public static void Projection()
        {
            var numbers = new int[] { 1, 1, 2, 3, 4, 5, 6, 6 };

            //Select() method
            var filtered = numbers.Select(x => x * 3);
            Print(filtered);

            //SelectMany() method
            var airports = Default.GetDefaultAirports();
            var filtered2 = airports.SelectMany(x => x.Flights);
            Default.Print(filtered2);
        }
   
        

        public static void Grouping()
        {
            //GroupBy() method
            var flights = Default.GetDefaultFlights1();
            var groupedFlights = flights.GroupBy(flight => flight.Destination);

            foreach (var flight in groupedFlights)
            {
                Console.WriteLine(flight.ToString());
            }
        }

        public static void Ordering()
        {
            var letters = new string[] { "a", "basd", "aaa", "ca", "ba" };

            //OrderBy() and ThenBy() method
            var ordered = letters.OrderBy(x => x.Length).ThenBy(x => x);
            Print(ordered);

            //Reverse() method
            var reversed = ordered.Reverse();
            Print(reversed);
        }

        public static void SetOperators()
        {
            var letters = new string[] { "a", "basd", "aaa", "ca", "ba" };
            var letters2 = new string[] { "a", "aaa" };

            //Concat() method
            var concatenated = letters.Concat(letters2);
            Print(concatenated);

            //Union() method
            var union = letters.Union(letters2);
            Print(union);

            //Intersect() method
            var intersect = letters.Intersect(letters2);
            Print(intersect);

            //Except() method
            var except = letters.Except(letters2);
            Print(except);
        }

        public static void Convertion()
        {
            var list = new ArrayList();
            list.Add("string");
            list.Add(1);

            //OfType() method
            var typed = list.OfType<string>();
            foreach (var item in typed)
            {
                Console.WriteLine(item);
            }

            //ToList() method
            var array = new int[] { 1, 2, 3, 4, 5 };
            var toList = array.ToList();
            Print(toList);
        }

        public static void ElementOperators()
        {
            //First() method
            var array = new int[] { 1, 2, 3, 4, 5, 1 };
            Console.WriteLine(array.First());

            //Single() method
            //Console.WriteLine(array.Single()); //this line throws an exception because there are multiple 1s(first element)
        }

        public static void Aggregation()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 1 };

            //Count() method
            var count = array.Count(x => x % 2 == 0);
            Console.WriteLine(count);

            //Sum() and Average() methods
            Console.WriteLine($"The sum is {array.Sum()} and the average is {array.Average()}");
        }

        public static void Quantifiers()
        {
            var intList = new List<int>();
            intList.Add(1);
            intList.Add(3);
            intList.Add(6);
            intList.Add(7);
            intList.Add(5);
            intList.Add(3);

            var secondList = new List<int>();
            secondList.Add(1);
            secondList.Add(3);
            secondList.Add(6);
            secondList.Add(7);
            secondList.Add(5);
            secondList.Add(3);



            //Contains() method

            if (intList.Contains(3))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

            //Any() method
            if (intList.Any(x => x < 1))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

            //All() method
            if (intList.All(x => x < 10))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

            //SequenceEqual() method
            if (intList.SequenceEqual(secondList))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }

        public static void Generation()
        {
            //Empty() method
            var empty = Expression.Empty();

            //Repeat() method
            var repeat = string.Concat(Enumerable.Repeat("repeat", 3));
            Console.WriteLine(repeat);

            //Range() method
            var array = new int[] { 1, 2, 3, 4, 5, 1 };

            var marks = array[2..5];
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }
        }
    }
}
