using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public class PermanentTeacher : Teacher
    {
        public double Salary { get; set; }

        public PermanentTeacher(string name, int id, double salary) : base(name, id)
        {
            Salary = salary;
        }

        public override double GetSalary()
        {
            return Salary;
        }
    }
}
