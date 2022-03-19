using System;
using System.Collections.Generic;

namespace Generics2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Teacher t1 = new PermanentTeacher("alex", 3123, 3000);
            Teacher t2 = new PermanentTeacher("andy", 4444, 3000);
            Teacher t3 = new HourlyTeacher("vlad", 3123, 10.5, 40);

            Console.WriteLine(t1.Equals(t2));

            t1.PrintEnums();

            t1.AddToSchedule(10, "Math");
            t1.AddToSchedule(12, "CS");
            t1.AddToSchedule(16, "Calculus");

            t1.ShowTodaySchedule();

            Console.WriteLine();

            University university = new();
            university.AddTeacher(t1);
            university.AddTeacher(t2);
            university.AddTeacher(t3);
            university.AddTeacher(t1);

            Console.WriteLine(university.ToString());


        }
    }
}
