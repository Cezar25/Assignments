using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3
{
    //Am extins interfata IEnumerable pentru o colectie generica (List<Type>)
    public class University : IEnumerable<Teacher>
    {
        ////nullable property
        
        public string Name { get; set; }
        public List<Teacher> Teachers = new();
        public University()
        {
 
        }
        
        //Overloaded Constructors
        public University(string name)
        {
            this.Name = name;
        }
        

        IEnumerator<Teacher> IEnumerable<Teacher>.GetEnumerator()
        {
            return Teachers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void AddTeacher(Teacher teacher)
        {
            if (Teachers.Contains(teacher))
            {
                Console.WriteLine("Teacher "+ teacher.Name + " is already in the university!");
                return;
            } 
            Teachers.Add(teacher);
            Console.WriteLine("Added teacher " + teacher.Name + " to the university.\n");
        }
        

        public override string ToString()
        {
            string s = string.Empty;
            foreach (Teacher teacher in Teachers)
            {
                s += teacher.ToString() + "\n";
            }

            //String.Join("\n",Teachers.Select(x => x.ToString()));
        
            return s;
        }

        public static implicit operator University(List<Teacher> v)
        {
            throw new NotImplementedException();
        }

        public static University GetDefaultUniversity()
        {
            Teacher t1 = new HourlyTeacher("alex", 40000, 40, 10.5);
            Teacher t2 = new HourlyTeacher("andy", 50000, 40, 12.3);
            Teacher t3 = new HourlyTeacher("paul", 56000, 30, 21); // 

            Teacher t4 = new PermanentTeacher("mihai", 423423, 15897);
            Teacher t5 = new PermanentTeacher("vali", 23423, 23456);

            University university = new University();
            university.AddTeacher(t1);
            university.AddTeacher(t2);
            university.AddTeacher(t3);
            university.AddTeacher(t4);
            university.AddTeacher(t5);



            university.Teachers = new List<Teacher>
            {
                new HourlyTeacher("alex", 40000, 40, 10.5),
                new HourlyTeacher("andy", 50000, 40, 12.3),
                new HourlyTeacher("paul", 56000, 30, 21)
            };

            return university;
        }
    }
}
