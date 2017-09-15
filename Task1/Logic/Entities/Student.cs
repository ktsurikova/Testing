using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public List<SubjectMarks> SubjectMarks { get; }

        public Student(string firstName, string lastName, params SubjectMarks[] subjectMarks)
        {
            FirstName = firstName;
            LastName = lastName;
            if (subjectMarks == null) SubjectMarks = new List<SubjectMarks>();
            else
            {
                SubjectMarks = new List<SubjectMarks>(subjectMarks.Length);
                Array.ForEach(subjectMarks, i => SubjectMarks.Add(i));
            }
        }
    }
}
