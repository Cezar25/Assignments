using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3
{
    public class PermanentTeacher : Teacher
    {
        public double Salary { get; set; }
        public PermanentTeacher(string name, int id, double salary) : base(name, id)
        {
            this.Salary = salary;
        }

        public override double GetSalary()
        {
            return Salary;
        }
    }
}
