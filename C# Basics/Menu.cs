using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3
{
    public class Menu
    {
        public static void Start(University university)
        {
            Console.Clear();

            while (true)
            {

                Console.WriteLine("Press 0 for printing university");
                Console.WriteLine("Press 1 for exiting");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        {
                            Console.WriteLine(university.ToString());
                            break;
                        }
                    case 1:
                        {
                            return;

                        }
                }
            }
        
    }
    }
}
