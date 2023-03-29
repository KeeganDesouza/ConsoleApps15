using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Keegan De souza 06/02/2023
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            ConsoleHelper.OutputHeading(" BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine();

            string[] choices = {" Distance Converter"," BMI Calculator"," Student Grades"};

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice ==1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.ConvertDistance();
            }
            else if (choice ==2)
            {
                BMI bmi = new BMI();
                bmi.CalculateIndex();
            }
            else if (choice == 3)
            {
                StudentGrades studentGrades = new StudentGrades();
                studentGrades.MainMenu();
            }
            else Console.WriteLine("Invalid Choice !");
        }
    }
}
