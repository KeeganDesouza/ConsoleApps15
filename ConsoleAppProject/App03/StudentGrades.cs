using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
//using ConsoleAppProject.App01;
//using ConsoleAppProject.App02;
using ConsoleAppProject.Helpers;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppProject.App03
{

    /// <summary>
    /// This App will prompt the user to input marks for the displayed students
    /// and then display the list of students with their marks and grade
    /// it will then Calculate and display the Average mark, the minimum mark and the maximum mark
    /// furthermore it would also be Calculating and displaying
    /// a grade profile(the percentage of students obtaining each grade).
    /// </summary>
    /// <author>
    /// Keegan De souza App03
    /// Last modified 15/03/2023
    /// </author>
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
        public Grades[] CalculateGrade { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        /// <summary>
        /// Class Constructor called when an object 
        /// is created and sets up an array of students.
        /// </summary>
        public StudentGrades()
        {
            //Array list of student names
            Students = new string[]
            {
            "Jacob", "Denes", "Chris",
            "Alice", "Talha", "Danny",
            "Rocky", "Phebe", "Miski",
            "Jamal"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
            CalculateGrade = new Grades[Marks.Length];
        }

        ///<Summary>
        ///Input a mark between 0-100 for each 
        ///student and store it in the Marks array
        ///</Summary>
        public void InputMarks()
        {
                Console.WriteLine();
                Console.Write("Please enter a mark for each student");
                Console.WriteLine();
            // take input for student marks using a loop
            for (int i = 0; i < Students.Length; i++)
            {
                //Checks for invalid numbers such as special characters by the help of console helpers. 
                //Asks the user to enter marks for each student.
                Marks[i] = Convert.ToInt32(ConsoleHelper.InputNumber($"Enter marks for {Students[i]}: " ));

            }

        }

        ///<summary>
        ///List all the students and display their 
        ///name and current mark
        ///</Summary>
        public void OutputMarks()
        {
            Console.WriteLine();
            ConsoleHelper.OutputTitle("Listing of student Marks");
            Console.WriteLine();
            WorkoutGrades();
            // print out the student names,marks and grades
            for (int i = 0; i < Students.Length; i++)
            
            {
                Console.WriteLine($" Student {Students[i]} Mark = {Marks[i]} Grade = {CalculateGrade[i]}");
            }         

        }

        ///<summary>
        ///Used to convert the student Grades 
        ///based on the students Marks 
        ///and then outputed as Grades(CalculateGrade) in the outputmarks.
        ///</Summary>
        public void WorkoutGrades()
        {
            // print out the grades for each student
            for (int i = 0; i < Marks.Length; i++)
            {
                Grades x = ConvertToGrade(Marks[i]);
                CalculateGrade[i] = x;
            }

        }

        ///<summary>
        ///Converts a student mark to a grade
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
            Console.WriteLine($" The average student marks is {Mean},\n the minimum student marks is {Minimum}," +
                $"\n the maximum student marks is {Maximum}");
        }

        ///<summary>
        ///Calculates the grades taken from the students marks
        ///and then outputs it to the grade profile.
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

        ///<summary>
        ///Converts the grades taken from the students 
        ///and then displays the percentage and counts 
        ///the ammount of student that have received similar grade overall.
        ///</summary
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
           
        }
        ////<summary>
        ///This is a MainMenu list that displays and
        ///Outputs the heading along with my name
        ///it also holds the if statments to allow the user to choose from.
        ///<summary>
        public void MainMenu()
        {
            ConsoleHelper.OutputHeading("Student Grades App");
            Console.WriteLine();
            
            //choices to choose from
            string[] choices = new string[]
            {
                "Input Marks",
                "Output Marks",
                "Output Stats",
                "Output Grade Profile",
                "Exit"
            };

            int choice = ConsoleHelper.SelectChoice(choices);

            ///<summary>
            ///if statments have been used to help choose
            ///between this 5 options and or exit the application.
            ///</summary
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
     
        }
    }
}

