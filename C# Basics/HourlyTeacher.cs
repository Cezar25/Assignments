using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3
{
    public class HourlyTeacher : Teacher
    {
        public int WorkedHours { get; set; }
        public double Rate { get; set; }
        public HourlyTeacher(string name, int id, int workedHours, double rate) : base(name, id)
        {
            this.WorkedHours = workedHours;
            this.Rate = rate;
        }

        public override double GetSalary()
        {
            return WorkedHours * Rate;
        }
    }
}
