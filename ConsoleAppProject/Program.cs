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

            Console.WriteLine("1 Distance Converter");
            Console.WriteLine("2 BMI Calculator");
            Console.WriteLine();
            // if statments required for user choice (1,2)
            Console.WriteLine("Please enter your choice of App > ");
            string choice = Console.ReadLine();

            if (choice =="1")
            {
                DistanceConverter converter = new DistanceConverter();
                converter.ConvertDistance();
            }
            else if (choice =="2")
            {
                BMI bmi = new BMI();
                bmi.CalculateIndex();
            }
            else Console.WriteLine("INVALID CHOICE");

        }
    }
}
