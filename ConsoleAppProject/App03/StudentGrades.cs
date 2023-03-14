using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {

        //Constants (Grade Boundaries)
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //properties 
        public string[] Students { get; set; }

        public int[] Marks { get; set; }
        
        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get ; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// Class Constructor called when an object 
        /// is created and sets up an array of students.
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
            "Jacob", "Dion", "Christina",
            "Alice", "Sam", "Daniel",
            "Rocky", "Phebe", "Adi",
            "Jamal"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        ///<Summary>
        ///Input a mark between 0-100 for each 
        ///student and store it in the Marks array
        ///</Summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        ///<summary>
        ///List all the students and display their 
        ///name and current mark
        ///</Summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        ///<summary>
        ///Convert a student mark to a grade
        ///from F (Fail) to A (First Class)
        ///</summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else return Grades.D;
        }

        ///<summary>
        ///Calculate and display the minimum, maximum 
        ///and mean mark for all students
        ///</summary
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }

        ///<summary>
        ///
        ///
        ///</summary
        public void CalculateGradeProfile()
        {
            throw new NotImplementedException();
        }

    }
}
