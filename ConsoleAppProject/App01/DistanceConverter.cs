using System;
using System.Data;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Keegan De souza 0.1
    /// </author>
    public class DistanceConverter
    {

        public const int FEET_IN_MILES = 5280;
        
        private double miles;

        private double feet;

        /// <Summary>
        /// 
        /// <Summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("        Convert Miles to Feet          ");
            Console.WriteLine("          by Keegan De souza           ");
            Console.WriteLine("-------------------------------------\n");
        }

        /// <Summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// <Summary>
        private void InputMiles() 
        {
            Console.WriteLine("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <Summary>
        /// 
        /// <Summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        /// <Summary>
        /// 
        /// <Summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

    }
}
