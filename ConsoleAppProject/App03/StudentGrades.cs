using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public Grades[] FigureGrade { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        public Grades Grades
        {
            get => default;
            set
            {
            }
        }

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
            FigureGrade = new Grades[Marks.Length];
        }

        ///<Summary>
        ///Input a mark between 0-100 for each 
        ///student and store it in the Marks array
        ///</Summary>
        public void InputMarks()
        {
                Console.WriteLine();
                Console.Write(" Please enter a mark for each student");
                Console.WriteLine();
            // take input for student marks using a loop
            for (int i = 0; i < Students.Length; i++)
            {
                Console.Write(" Enter marks for : ", Students[i]);
                Marks[i] = int.Parse(Console.ReadLine());
            }

        }

        ///<summary>
        ///List all the students and display their 
        ///name and current mark
        ///</Summary>
        public void OutputMarks()
        {
            Console.WriteLine();
            Console.Write(" Output Students Marks and Grades");
            Console.WriteLine();
            WorkoutGrades();
            // print out the student names,marks and grades
            for (int i = 0; i < Students.Length; i++)
            
            {
                Console.WriteLine($" {Students[i]}: {Marks[i]} is Grade {FigureGrade[i]}");
            }         

        }

        public void WorkoutGrades()
        {
            // print out the grades for each student
            for (int i = 0; i < Marks.Length; i++)
            {
                Grades x = ConvertToGrade(Marks[i]);
                FigureGrade[i] = x;
            }

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
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            return Grades.F;
        }

        ///<summary>
        ///Calculate and display the minimum, maximum 
        ///and mean mark for all students
        ///</summary
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach(int mark in Marks) 
            {   
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total += mark;
            }

            Mean = total / Marks.Length;
            Console.WriteLine($" The average student marks is {Mean},\n the minimum mark is {Minimum},\n the maximum mark is {Maximum}");
        }

        ///<summary>
        ///
        ///
        ///</summary
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }
        public void OutputGradeProfile()
        {
            Grades grade = Grades.F;
            Console.WriteLine();
            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($" Grade {grade} {percentage}% Count {count}");
                grade++;
            }
            MainMenu();
        }

        public void CalculateGrades()
        {
            ConsoleHelper.OutputHeading("Student Grades App");
            Console.WriteLine();
            MainMenu();
        }

        private void MainMenu()
        {
            string[] choices = new string[]
            {
                "Input Marks",
                "Output Marks",
                "Output Stats",
                "Output Grade Profile",
                "Exit"
            };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                InputMarks();
                Console.WriteLine();
                MainMenu();
            }
            else if  (choice == 2) 
            { 
                OutputMarks();
                Console.WriteLine();
                MainMenu();
            }
            else if (choice == 3)
            {
                CalculateStats();
                Console.WriteLine();
                MainMenu();
            }
            else if (choice == 4)
            {
                OutputGradeProfile();
                Console.WriteLine();
                MainMenu();
            }
            else if (choice == 5)
            {
                Environment.Exit(0);
            }



        }


    }

}

