using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public abstract class Teacher : IEquatable<Teacher>
    {
        public string Name { get; set; }
        public int Id { get; set; }
        //Nullable field
        private readonly int? phdNumber = null;

        //Used dictionary for the teacher's schedule
        private Dictionary<int, string> schedule = new Dictionary<int, string>();

        public void AddToSchedule(int time, string subject)
        {
            schedule.Add(time, subject);
        }

        public enum Classes
        {
            Math = 1,
            English = 2,
            CS = 3,
            History = 4
        }

        public Teacher(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public Teacher(string name, int id, int? phdNumber) : this(name, id)
        {
            this.phdNumber = phdNumber;
        }

        public bool HasPhd()
        {
            if (phdNumber.HasValue)
                return true;
            return false;
        }

        public abstract double GetSalary();
        public override string ToString()
        {
            return $"Name: {Name} ID: {Id} ";
        }

        public void PrintEnums()
        {
            Console.WriteLine($"\n Math:{(int)Classes.Math} \n English:{(int)Classes.English} \n CS:{(int)Classes.CS} \n History:{(int)Classes.History} \n");
        }

        //Comparer method
        public bool Equals(Teacher other)
        {
            return this.Name.Equals(other.Name) && this.Id == other.Id;
        }

        //Iterating through dictionary method
        public void ShowTodaySchedule()
        {
            foreach (KeyValuePair<int, string> pair in schedule)
            {
                Console.WriteLine($"Time: {pair.Key}  Subject: {pair.Value}");
            }
        }
    }
}
