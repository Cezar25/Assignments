using System;

namespace Strings_and_Dates
{
    class Program
    {
        //Mic console app facut folosing metodele invatate la curs
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your first name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your surname: ");
            var surname = Console.ReadLine();

            Console.WriteLine($"Your full name is: {name} {surname}"); 

            
            Console.WriteLine("Enter a list of things, separated by commas: ");
            var commas = Console.ReadLine();
            var split = commas.Split(',');
            Console.WriteLine($"The list is:");
            foreach(var spl in split)
            {
                Console.WriteLine(spl);
            } 

            Console.WriteLine("Does your name contain the letter 'a'?");
            var fullname = name + surname;
            if(fullname.Contains('a'))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.WriteLine("Which of your names is bigger according to the ASCII code?");
            if(string.Compare(name,surname,StringComparison.InvariantCultureIgnoreCase)>=0)
                Console.WriteLine("Your first name");
            else
                Console.WriteLine("Your surname");

            string currentDate = DateTime.UtcNow.ToString("yyyy-MM-dd");
            Console.WriteLine(currentDate);
            Console.WriteLine($"The current date is {currentDate}");

            Console.WriteLine("Enter a year: ");
            var year = Console.ReadLine();
            Console.WriteLine("Enter a month: ");
            var month = Console.ReadLine();
            Console.WriteLine("Enter a day: ");
            var day = Console.ReadLine();

            var date = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
            var formattedDate = date.ToString("yyyy-MM-dd");
            Console.WriteLine($"The date you entered is {formattedDate}");
        }
    }
}
