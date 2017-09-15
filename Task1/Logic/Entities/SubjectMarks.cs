using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class SubjectMarks
    {
        public Subject Subject { get; }
        public List<int> Marks { get; }

        public SubjectMarks(Subject subject, params int[] marks)
        {
            Subject = subject;

            if (marks==null) Marks = new List<int>();
            else
            {
                Marks = new List<int>(marks.Length);
                Array.ForEach(marks, i => Marks.Add(i));
            }
        }
    }
}
