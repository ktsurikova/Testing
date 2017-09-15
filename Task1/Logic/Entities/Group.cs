using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Group
    {
        public int Number { get; }
        public List<Student> Students { get; }

        public Group(int number, params Student[] students)
        {
            Number = number;
            if (students == null) Students = new List<Student>();
            else
            {
                Students = new List<Student>(students.Length);
                Array.ForEach(students, i => Students.Add(i));
            }
        }
    }
}
