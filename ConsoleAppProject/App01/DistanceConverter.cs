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

        //Distance variables
        private const string FEET = "Feet";
        private const string METERS = "Meters";
        private const string MILES = "Miles";
        private const string KILOMETERS = "Kilometers";
        private const string CENTIMETERS = "Centimeters";
        private const string MILIMETERS = "Milimeters";

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

            if (fromUnit == KILOMETERS && toUnit == METERS)
            {
                toDistance = fromDistance * METERS_IN_KILOMETERS;
            }
            else if (fromUnit == METERS && toUnit == KILOMETERS)
            {
                toDistance = fromDistance / METERS_IN_KILOMETERS;
            }

            if (fromUnit == KILOMETERS && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_KILOMETERS;
            }
            else if (fromUnit == FEET && toUnit == KILOMETERS)
            {
                toDistance = fromDistance / FEET_IN_KILOMETERS;
            }

            if (fromUnit == KILOMETERS && toUnit == MILES)
            {
                toDistance = fromDistance / MILES_IN_KILOMETERS;
            }
            else if (fromUnit == MILES && toUnit == KILOMETERS)
            {
                toDistance = fromDistance * MILES_IN_KILOMETERS;
            }

            if (fromUnit == METERS && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETERS_IN_METERS;
            }
            else if (fromUnit == CENTIMETERS && toUnit == METERS)
            {
                toDistance = fromDistance / CENTIMETERS_IN_METERS;
            }

            if (fromUnit == KILOMETERS && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETERS_IN_KILOMETERS;
            }
            else if (fromUnit == CENTIMETERS && toUnit == KILOMETERS)
            {
                toDistance = fromDistance / CENTIMETERS_IN_KILOMETERS;
            }

            if (fromUnit == MILES && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETERS_IN_MILES;
            }
            else if (fromUnit == CENTIMETERS && toUnit == MILES)
            {
                toDistance = fromDistance / CENTIMETERS_IN_MILES;
            }

            if (fromUnit == FEET && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance * CENTIMETERS_IN_FEET;
            }
            else if (fromUnit == CENTIMETERS && toUnit == FEET)
            {
                toDistance = fromDistance / CENTIMETERS_IN_FEET;
            }

            if (fromUnit == MILIMETERS && toUnit == METERS)
            {
                toDistance = fromDistance / METERS_IN_MILIMETERS;
            }
            else if (fromUnit == METERS && toUnit == MILIMETERS)
            {
                toDistance = fromDistance * METERS_IN_MILIMETERS;
            }

            if (fromUnit == KILOMETERS && toUnit == MILIMETERS)
            {
                toDistance = fromDistance * MILIMETERS_IN_KILOMETERS;
            }
            else if (fromUnit == MILIMETERS && toUnit == KILOMETERS)
            {
                toDistance = fromDistance / MILIMETERS_IN_KILOMETERS;
            }

            if (fromUnit == MILIMETERS && toUnit == CENTIMETERS)
            {
                toDistance = fromDistance / CENTIMETERS_IN_MILIMETERS;
            }
            else if (fromUnit == CENTIMETERS && toUnit == MILIMETERS)
            {
                toDistance = fromDistance * CENTIMETERS_IN_MILIMETERS;
            }

            if (fromUnit == MILIMETERS && toUnit == MILES)
            {
                toDistance = fromDistance / MILES_IN_MILIMETERS;
            }
            else if (fromUnit == MILES && toUnit == MILIMETERS)
            {
                toDistance = fromDistance * MILES_IN_MILIMETERS;
            }

            if (fromUnit == FEET && toUnit == MILIMETERS)
            {
                toDistance = fromDistance * MILIMETERS_IN_FEET;
            }
            else if (fromUnit == MILIMETERS && toUnit == FEET)
            {
                toDistance = fromDistance / MILIMETERS_IN_FEET;
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
            Console.WriteLine($" 4. {KILOMETERS}");
            Console.WriteLine($" 5. {CENTIMETERS}");
            Console.WriteLine($" 6. {MILIMETERS}");
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



