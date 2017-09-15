using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Entities;

namespace Logic
{
    public static class GPAService
    {
        public static double Subject(University university, Subject subject)
        {
            double count = 0;
            int numberOfMarks = 0;

            foreach (var f in university.Faculties)
            {
                foreach (var g in f.Groups)
                {
                    foreach (var s in g.Students)
                    {
                        foreach (var sm in s.SubjectMarks)
                        {
                            if (sm.Subject == subject)
                            {
                                foreach (var m in sm.Marks)
                                {
                                    count += m;
                                    numberOfMarks++;
                                }
                            }
                        }
                    }
                }
            }

            return numberOfMarks == 0 ? 0 : count / numberOfMarks;
        }

        public static double Student(Student student)
        {
            int numberOfMarks = 0;
            int count = 0;
            foreach (var t in student.SubjectMarks)
            {
                foreach (var m in t.Marks)
                {
                    count += m;
                    numberOfMarks++;
                }
            }
            return numberOfMarks == 0 ? 0 : (double)count / numberOfMarks;
        }

        public static double Group(Group group)
        {
            double count = 0;
            foreach (var s in group.Students)
            {
                count += Student(s);
            }
            return group.Students.Count == 0 ? 0 : count / group.Students.Count;
        }

        public static double Faculty(Faculty faculty)
        {
            double count = 0;
            foreach (var s in faculty.Groups)
            {
                count += Group(s);
            }
            return faculty.Groups.Count == 0 ? 0 : count / faculty.Groups.Count;
        }

        public static double University(University university)
        {
            double count = 0;
            foreach (var s in university.Faculties)
            {
                count += Faculty(s);
            }
            return university.Faculties.Count == 0 ? 0 : count / university.Faculties.Count;
        }
    }
}
