using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit and it will calculate and 
    /// output the equivalent distance in another unit.
    /// </summary>
    /// <author>
    /// Keegan De souza 0.3
    /// </author>
    public class DistanceConverter
    {
        //Distance conversion constants
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        //Distance variables
        private double miles;

        private double feet;

        private double meters;

        /// <Summary>
        /// This method will input the distance measured in miles 
        /// calculate the same distance in feet, and output the 
        /// distance in feet.
        /// <Summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of miles > ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Please enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMeters()
        {
            OutputHeading("Converting Miles to Meters");

            miles = InputDistance("Please enter the number of miles > ");
            CalculateMeters();
            OutputDistance(miles, nameof(miles), meters, nameof(meters));
        }
        /// <Summary>
        /// prompt the user to enter the distance in miles
        /// input the miles as a double number
        /// <Summary>
        private double InputDistance(String prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <Summary>
        /// 
        /// <Summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <Summary>
        /// 
        /// <Summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <Summary>
        /// 
        /// <Summary>
        private void CalculateMeters()
        {
            meters = miles * METERS_IN_MILES;
        }

        /// <Summary>
        /// 4 parameters added to convert distance
        /// general purposes distance convert
        /// <Summary>
        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }

        /// <Summary>
        /// Output a short description of the application
        /// and the name of the author.
        /// <Summary>
        private void OutputHeading(string prompt)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("        Distance converter         ");
            Console.WriteLine("        by Keegan De souza           ");
            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine("prompt");
            Console.WriteLine("");
        }

    }
}



