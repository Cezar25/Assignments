using System;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4 };

            GenericArray<int> genericArray = new GenericArray<int>(arr);

            while (true)
            {
                Console.WriteLine("Press 1 for getting at index");
                Console.WriteLine("Press 2 for setting at index");
                Console.WriteLine("Press 3 for swapping items");
                Console.WriteLine("Press 4 for displaying array");
                Console.WriteLine("Press 0 for exiting the program");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        {
                            Console.WriteLine("Type in index");
                            var index = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"The item is: {genericArray.GetByIndex(index)}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Type in index:");
                            var index = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Type in value(int):");                           
                            var value = Convert.ToInt32(Console.ReadLine());
                            genericArray.SetByIndex(index, value);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Type in item1(int):");
                            var item1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Type in item2(int):");
                            var item2 = Convert.ToInt32(Console.ReadLine());
                            genericArray.SwapItems(item1, item2);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("The array is: \n");
                            foreach (var item in genericArray)
                                Console.Write($"{item} ");
                            break;
                        }
                   
                }
            }
        }
    }
}
