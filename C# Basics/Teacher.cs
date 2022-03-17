using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3
{
    public abstract class Teacher
    {

        public string Name { get; set; }
        public int Id { get; set; }

        public Teacher(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public abstract double GetSalary();

        
        public override String ToString()
        {
            return "Name: " + Name + " id: "+ Id + " salary: " + GetSalary();
        }       

    }
}
