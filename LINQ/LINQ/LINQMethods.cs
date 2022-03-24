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
                Console.Write($"{thing} \n");
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

            //Skip() method
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

        public class FoodOrderingPerson
        {
            public FoodOrderingPerson(string name, string town)
            {
                Name = name;
                Town = town;
            }

            public string Name { get; set; }
            public string Town { get; set; }
        }

        public class FoodDeliveringPerson
        {
            public FoodDeliveringPerson(string company, string town)
            {
                Company = company;
                Town = town;
            }

            public string Company { get; set; }
            public string Town { get; set; }

            
        }


   
        public static void Joins()
        {
            var customers = new List<FoodOrderingPerson>()
            {
                new FoodOrderingPerson("Andrei","Bucuresti"),
                new FoodOrderingPerson("Alex","Timisoara"),
                new FoodOrderingPerson("Andi","Arad")
            };
            var deliverers = new List<FoodDeliveringPerson>()
            {
                new FoodDeliveringPerson("Glovo","Arad"),
                new FoodDeliveringPerson("Tazz","Bucuresti"),
                new FoodDeliveringPerson("UberEats","Timisoara")
            };

            //Join() method
            var joined = from customer in customers
                         join deliverer in deliverers on customer.Town equals deliverer.Town
                         select new {customer.Name, deliverer.Company };

            Print(joined);

            //GroupJoin() method 
            var groupJoined = from customer in customers
                              join deliverer in deliverers on customer.Town equals deliverer.Town into foodieGroup
                              select new { customer.Name, foodieGroup };
            foreach (var itemGroup in groupJoined)
            {
                foreach (var item2 in itemGroup.foodieGroup)
                {
                    Console.WriteLine(item2);
                }
            }

            //Zip() method
            var zipped = customers.Zip(deliverers, (first, second) => first.Name + "ordered from " + second.Company);
            Print(zipped);
        }

        public static void Grouping()
        {
            //GroupBy() method
            var flights = Default.GetDefaultFlights1();
            var groupedFlights = flights.GroupBy(flight => flight.HasBusinessClass);

            foreach (var destination in groupedFlights)
            {
                Console.WriteLine(destination.Key);
                foreach (var flight in destination)
                {
                    Console.WriteLine(flight);
                }
            }
        }

        public static void Ordering()
        {
            var letters = new string[] { "a", "basd", "aaa", "ca", "ba" };

            //OrderBy() and ThenBy() method
            var ordered = letters.OrderBy(x => x.Length).ThenBy(x => x);
            Print(ordered);

            //OrderDescending() and ThenOrderDescending()
            var orderedDescending = letters.OrderByDescending(x => x.Length).ThenBy(x => x);
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

            //Cast() method
            var numbersArrayList = new ArrayList();
            numbersArrayList.Add(1);
            numbersArrayList.Add(2);
            numbersArrayList.Add(3);
            var filteredNumbers = numbersArrayList.Cast<int>().OrderByDescending(number => number);
            Print(filteredNumbers);

            //ToArray() method
            var normalList = new List<int>() { 1, 2, 3, 4 };
            var listToArray = normalList.ToArray();
            Print(listToArray);

            //ToDictionary() method
            var toDictionary = normalList.ToDictionary(x => x);

            //ToLookup() method
            var lookup = normalList.ToLookup(x => x);

            //AsQuery() method
            var asQuery = normalList.AsQueryable();
            

            //ToList() method
            var array = new int[] { 1, 2, 3, 4, 5 };
            var toList = array.ToList();
            Print(toList);
        }

        public static void ElementOperators()
        {
            //First() or FirstOrDefault() method
            var array = new int[] { 1, 2, 3, 4, 5, 1 };
            Console.WriteLine(array.FirstOrDefault());

            //Last() or LastOrDefault() method
            Console.WriteLine(array.LastOrDefault(x => x % 5 == 0));

            //Single() method
            //Console.WriteLine(array.Single()); //this line throws an exception because there are multiple 1s(first element)

            //ElementAt() method or ElementAtDefault() method
            Console.WriteLine(array.ElementAt(3));

            //DefaultOrEmpty
            var emptyList = new List<int>();
            Print(emptyList);
        }

        public static void Aggregation()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 1 };

            //Count() method
            var count = array.Count(x => x % 2 == 0);
            Console.WriteLine(count);

            //Min,Max() methods
            var min = array.Min();
            var max = array.Max();

            //Sum() and Average() methods
            Console.WriteLine($"The sum is {array.Sum()} and the average is {array.Average()}");

            //Aggregate() method
            var fruits = new string[] { "apple", "mango", "orange", "passionfruit", "grape" };
            var longest = fruits.Aggregate("banana", (longest, next) => next.Length > longest.Length ? next : longest, fruit => fruit.ToUpper());

            Console.WriteLine(longest);
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
