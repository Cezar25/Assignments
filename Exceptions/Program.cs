using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Exceptions
{
    class Program
    {
        public static int DivByThree(int number) // arunca exceptie daca argumentul nu a multiplu de 3
        {
            if(number % 3 != 0)
            {
                throw new ArgumentException($"The parameter is not a multiple of 3!");
            }
            return number / 3;
        }
        public static int MultiPos(int number1, int number2) // arunca exceptie daca oricare dintre argumente este negativ
        {
            if (number1 < 0)
            {
                throw new ArgumentException($"{number1} is a negative number!");
            }
            if (number2 < 0)
            {
                throw new ArgumentException($"{number2} is a negative number!");
            }
            return number1 * number2;
        }
        public static void TestArgumentExceptions()
        {
            //testarea functiei DivByThree
            try
            {
                Console.WriteLine(DivByThree(12));
                Console.WriteLine(DivByThree(11));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            try
            {
                Console.WriteLine(MultiPos(3, 2));
                Console.WriteLine(MultiPos(3, -1));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);

            }
        }
#if RELEASE
        public static int HoursWorkedOnProject(int hours)
        {
            if(hours > 8)
            {
                throw new ArgumentException("Programmer is tired! He should work less!");
            }
            return hours;
        }
        public static void TryCatchFinally()
        {
            int workedHours;
            Console.WriteLine("Enter a number of hours for the programmer to work on the project: ");
            try
            {
                workedHours = HoursWorkedOnProject(Convert.ToInt32(Console.ReadLine()));
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                workedHours = 8;
            }
            finally
            {
                Console.WriteLine("The programmer has worked on the project!");
            }
        }
#endif

#if DEBUG
        public static void Validate(Student student)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(student.Name))
                throw new MyException(student.Name);

            if (student.Age < 14 || student.Age > 24)
                throw new MyException(student.Age);
        }
        public static void TestStudentException() //testing of the custom exception method
        {
            Student student = new Student();
            try
            {
                Console.WriteLine("Enter student's name: ");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter student's age: ");
                student.Age = Convert.ToInt32(Console.ReadLine());

                Validate(student);
            }
            catch(MyException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine($"Entered student's name and age are: {student.Name}, {student.Age}");
            }
        }
#endif 
        public static int DivideByZero(int number1, int number2)
        {
            try
            {
                return number1 / number2;
            }
            catch(DivideByZeroException exception)
            {
                Console.WriteLine("Dividing by 0 is forbidden!");
                throw;
            }
        }
        public static void TestRethrowException()
        {
            Console.WriteLine("Enter the number to be divided: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the divider: ");
            int divider = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DivideByZero(number, divider));
           
        }

        public static void WriteDebug()
        {
            Console.WriteLine("CHECK OUTPUT WINDOW!");
            Debug.WriteLine("User testing the program...");
        }
        static void Main(string[] args)
        {
            //TestArgumentExceptions();
            //TryCatchFinally();
            //TestStudentException();
            //TestRethrowException();
            WriteDebug();
        }
    }
}
