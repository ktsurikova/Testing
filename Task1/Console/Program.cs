using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Logic.Entities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Students

            Student s1 = new Student("John", "Mcrae",
            
                new SubjectMarks(Subject.MathematicalAnalysis, 8,7,6), 
                new SubjectMarks(Subject.LinearAlgebra, 9,8,7),
                new SubjectMarks(Subject.FunctionalAnalysis, 5,6,7)
            );

            Student s2 = new Student("Steven", "Lamb",

                new SubjectMarks(Subject.Geometry, 8, 7, 6),
                new SubjectMarks(Subject.Physics, 9, 8, 7),
                new SubjectMarks(Subject.MathematicalAnalysis, 5, 6, 7)
            );

            Student s3 = new Student("Sarah", "Nickols",

                new SubjectMarks(Subject.Physics, 8, 7, 6),
                new SubjectMarks(Subject.LinearAlgebra, 9, 8, 7),
                new SubjectMarks(Subject.DifferentialEquations, 5, 6, 7)
            );

            Student s4 = new Student("Andreas", "Hurd",

                new SubjectMarks(Subject.LinearAlgebra, 8, 7, 6),
                new SubjectMarks(Subject.DifferentialEquations, 9, 8, 7),
                new SubjectMarks(Subject.FunctionalAnalysis, 5, 6, 7)
            );

            Student s5 = new Student("Morgan", "Chiles",

                new SubjectMarks(Subject.MathematicalAnalysis, 8, 7, 6),
                new SubjectMarks(Subject.Physics, 9, 8, 7),
                new SubjectMarks(Subject.FunctionalAnalysis, 5, 6, 7)
            );

            #endregion

            #region Groups

            Group g1 = new Group(1, s1, s5);
            Group g2 = new Group(2, s2);
            Group g3 = new Group(3, s3);
            Group g4 = new Group(4, s4);

            #endregion

            #region Faculties

            Faculty f1 = new Faculty("MMF", g1, g2);
            Faculty f2 = new Faculty("MMF2", g3, g4);

            #endregion

            #region University

            University u = new University("BSU", f1, f2);

            #endregion
            // all students have GPA = 7
            Console.WriteLine($"GPA Linear Algebr: {GPAService.Subject(u, Subject.LinearAlgebra)}");
            Console.WriteLine($"GPA s1: {GPAService.Student(s1)}");
            Console.WriteLine($"GPA g1: {GPAService.Group(g1)}");
            Console.WriteLine($"GPA f1: {GPAService.Faculty(f1)}");
            Console.WriteLine($"GPA u: {GPAService.University(u)}");
            Console.ReadLine();
        }
    }
}
