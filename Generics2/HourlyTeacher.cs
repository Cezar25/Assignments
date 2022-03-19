using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public class HourlyTeacher : Teacher
    {
        public double Rate { get; set; }
        public int WorkedHours { get; set; }

        public HourlyTeacher(string name, int id, double rate, int workedHours) : base(name, id)
        {
            Rate = rate;
            WorkedHours = workedHours;
        }

        public override double GetSalary()
        {
            return Rate * WorkedHours;
        }
    }
}
