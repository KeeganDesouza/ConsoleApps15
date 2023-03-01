using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and 
    /// output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Keegan De souza 0.6
    /// </author>
    public class DistanceConverter
    {
        //Distance conversion constants
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        public const double FEET_IN_METERS = 3.28084;

        //Distance variables
        private const string FEET = "Feet";
        private const string METERS = "Meters";
        private const string MILES = "Miles";

        //Private Attributes(Global Variables) 
        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        //constructor to set default values 
        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }
        /// <Summary>
        /// This method will input the distance measured in miles 
        /// calculate the same distance in feet, and output the 
        /// distance in feet.
        /// <Summary>
        public void ConvertDistance()

        {
            OutputHeading();
            fromUnit = SelectUnit(" Select the from distance unit > ");
            toUnit = SelectUnit(" Select the to distance unit > ");
            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");
            CalculateDistance();
            OutputDistance();
        }

        //if statments used to calculate the conversion for the 3 diffrent distance.
        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if(fromUnit == FEET &&  toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }

            if (fromUnit == MILES && toUnit == METERS)
            {
                toDistance = fromDistance * METERS_IN_MILES;
            }
            else if (fromUnit == METERS && toUnit == MILES)
            {
                toDistance = fromDistance / METERS_IN_MILES;
            }

            if (fromUnit == METERS && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METERS;
            }
            else if (fromUnit == FEET && toUnit == METERS)
            {
                toDistance = fromDistance / FEET_IN_METERS;
            }


        }
        /// <Summary>
        /// Displays the chosen unit
        /// <Summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METERS;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }
        /// <Summary>
        /// prompt the user to chose from one of this option
        /// <Summary>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METERS}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
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
        /// 4 parameters added to convert distance
        /// general purposes distance convert
        /// <Summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance}  {fromUnit}" +
                $" is {toDistance} {toUnit}!\n");
        }

        /// <Summary>
        /// Output a short description of the application
        /// and the name of the author.
        /// <Summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("        Distance converter         ");
            Console.WriteLine("        by Keegan De souza           ");
            Console.WriteLine("-------------------------------------\n");
        }

    }
}



