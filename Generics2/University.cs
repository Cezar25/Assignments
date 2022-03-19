using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public class University : IEnumerable<Teacher>
    {
        //List collection
        public List<Teacher> Teachers = new();

        IEnumerator<Teacher> IEnumerable<Teacher>.GetEnumerator()
        {
            return Teachers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string s = "";
            foreach (var teacher in Teachers)
            {
                s += teacher.ToString() + "\n";
            }
            return s;
        }

        public void AddTeacher(Teacher teacher)
        {
            if (Teachers.Contains(teacher))
            {
                Console.WriteLine("TEacher already in university!");
                return;
            }
            Teachers.Add(teacher);
        }
    }
}
