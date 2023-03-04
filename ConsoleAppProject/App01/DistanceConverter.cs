using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit (fromUnit) and it will calculate and 
    /// output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Keegan De souza 0.7
    /// </author>
    public class DistanceConverter
    {
        //Distance conversion constants
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        public const double FEET_IN_METERS = 3.28084;

        public const int METERS_IN_KILOMETERS = 1000;

        public const double FEET_IN_KILOMETERS = 3280.839895;

        public const double MILES_IN_KILOMETERS = 1.60935;

        public const int CENTIMETERS_IN_METERS = 100;

        public const int CENTIMETERS_IN_KILOMETERS = 100000;

        public const int CENTIMETERS_IN_MILES = 160935;

        public const double CENTIMETERS_IN_FEET = 30.48;

        public const int METERS_IN_MILIMETERS = 1000;

        public const int MILIMETERS_IN_KILOMETERS = 1000000;

        public const int CENTIMETERS_IN_MILIMETERS = 10;

        public const int MILES_IN_MILIMETERS = 1609350;

        public const double MILIMETERS_IN_FEET = 304.8;

        ///Distance variables
        private const string FEET = "Feet";
        private const string METERS = "Meters";
        private const string MILES = "Miles";
        private const string KILOMETERS = "Kilometers";
        private const string CENTIMETERS = "Centimeters";
        private const string MILIMETERS = "Milimeters";

        ///Private Attributes(Global Variables) 
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        ///constructor to set default values 
        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }
        /// <Summary>
        /// This method will input the distance measured in miles 
        /// calculate the same distance in feet, and output the 
        /// distance in feet.
        /// <Summary>
        public void ConvertDistance()
        {   
            ConsoleHelper.OutputHeading(" Distance Converter ");
            Console.WriteLine();
            FromUnit = SelectUnit(" Select the from distance unit > ");
            ToUnit = SelectUnit(" Select the to distance unit > ");
            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");
            FromDistance = InputDistance($" Please enter the number of {FromUnit} > ");
            CalculateDistance();
            OutputDistance();
            
        }

        ///if statments used to calculate the conversion for the 6 diffrent distance.
        private void CalculateDistance()
        {
            if(FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if(FromUnit == FEET &&  ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }

            if (FromUnit == MILES && ToUnit == METERS)
            {
                ToDistance = FromDistance * METERS_IN_MILES;
            }
            else if (FromUnit == METERS && ToUnit == MILES)
            {
                ToDistance = FromDistance / METERS_IN_MILES;
            }

            if (FromUnit == METERS && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METERS;
            }
            else if (FromUnit == FEET && ToUnit == METERS)
            {
                ToDistance = FromDistance / FEET_IN_METERS;
            }

            if (FromUnit == KILOMETERS && ToUnit == METERS)
            {
                ToDistance = FromDistance * METERS_IN_KILOMETERS;
            }
            else if (FromUnit == METERS && ToUnit == KILOMETERS)
            {
                ToDistance = FromDistance / METERS_IN_KILOMETERS;
            }

            if (FromUnit == KILOMETERS && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_KILOMETERS;
            }
            else if (FromUnit == FEET && ToUnit == KILOMETERS)
            {
                ToDistance = FromDistance / FEET_IN_KILOMETERS;
            }

            if (FromUnit == KILOMETERS && ToUnit == MILES)
            {
                ToDistance = FromDistance / MILES_IN_KILOMETERS;
            }
            else if (FromUnit == MILES && ToUnit == KILOMETERS)
            {
                ToDistance = FromDistance * MILES_IN_KILOMETERS;
            }

            if (FromUnit == METERS && ToUnit == CENTIMETERS)
            {
                ToDistance = FromDistance * CENTIMETERS_IN_METERS;
            }
            else if (FromUnit == CENTIMETERS && ToUnit == METERS)
            {
                ToDistance = FromDistance / CENTIMETERS_IN_METERS;
            }

            if (FromUnit == KILOMETERS && ToUnit == CENTIMETERS)
            {
                ToDistance = FromDistance * CENTIMETERS_IN_KILOMETERS;
            }
            else if (FromUnit == CENTIMETERS && ToUnit == KILOMETERS)
            {
                ToDistance = FromDistance / CENTIMETERS_IN_KILOMETERS;
            }

            if (FromUnit == MILES && ToUnit == CENTIMETERS)
            {
                ToDistance = FromDistance * CENTIMETERS_IN_MILES;
            }
            else if (FromUnit == CENTIMETERS && ToUnit == MILES)
            {
                ToDistance = FromDistance / CENTIMETERS_IN_MILES;
            }

            if (FromUnit == FEET && ToUnit == CENTIMETERS)
            {
                ToDistance = FromDistance * CENTIMETERS_IN_FEET;
            }
            else if (FromUnit == CENTIMETERS && ToUnit == FEET)
            {
                ToDistance = FromDistance / CENTIMETERS_IN_FEET;
            }

            if (FromUnit == MILIMETERS && ToUnit == METERS)
            {
                ToDistance = FromDistance / METERS_IN_MILIMETERS;
            }
            else if (FromUnit == METERS && ToUnit == MILIMETERS)
            {
                ToDistance = FromDistance * METERS_IN_MILIMETERS;
            }

            if (FromUnit == KILOMETERS && ToUnit == MILIMETERS)
            {
                ToDistance = FromDistance * MILIMETERS_IN_KILOMETERS;
            }
            else if (FromUnit == MILIMETERS && ToUnit == KILOMETERS)
            {
                ToDistance = FromDistance / MILIMETERS_IN_KILOMETERS;
            }

            if (FromUnit == MILIMETERS && ToUnit == CENTIMETERS)
            {
                ToDistance = FromDistance / CENTIMETERS_IN_MILIMETERS;
            }
            else if (FromUnit == CENTIMETERS && ToUnit == MILIMETERS)
            {
                ToDistance = FromDistance * CENTIMETERS_IN_MILIMETERS;
            }

            if (FromUnit == MILIMETERS && ToUnit == MILES)
            {
                ToDistance = FromDistance / MILES_IN_MILIMETERS;
            }
            else if (FromUnit == MILES && ToUnit == MILIMETERS)
            {
                ToDistance = FromDistance * MILES_IN_MILIMETERS;
            }

            if (FromUnit == FEET && ToUnit == MILIMETERS)
            {
                ToDistance = FromDistance * MILIMETERS_IN_FEET;
            }
            else if (FromUnit == MILIMETERS && ToUnit == FEET)
            {
                ToDistance = FromDistance / MILIMETERS_IN_FEET;
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

        ///<summary>
        ///Prompts the user to select the from distance and to distance unit
        ///if an invalid choice has been chosen an error message would display
        ///with a prompt and repeat the choices due to the if statments.
        ///</summary>
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
            else if (choice.Equals("4"))
            {
                return KILOMETERS;
            }
            else if (choice.Equals("5"))
            {
                return CENTIMETERS;
            }
            else if (choice.Equals("6"))
            {
                return MILIMETERS;
            }
            else
            {
                Console.WriteLine(" Invalid Choice !");
            }
            return null;
        }
        /// <Summary>
        /// prompt the user to chose from one of this option
        /// <Summary>
        private static string DisplayChoices(string prompt)
        {
            string[] choices = { "Feet", "Meters", "Miles", "Kilometers", "Centimeters", "Milimeters" };
            int choice = ConsoleHelper.SelectChoice(choices);

            return Convert.ToString(choice);
            
        }
        /// <Summary>
        /// prompt the user to enter the distance in miles
        /// input the miles as a double number
        /// the console helpers is also utilized to add a prompt suggesting if a invalid distance has been added.
        /// <Summary>
        private double InputDistance(String prompt)
        {
            double value = ConsoleHelper.InputNumber(prompt);
            return value;
        }


        /// <Summary>
        /// 4 parameters added to convert distance
        /// general purposes distance convert
        /// <Summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance}  {FromUnit}" +
                $" is {ToDistance} {ToUnit}!\n");
            Console.ReadLine();
        }
    }
}



