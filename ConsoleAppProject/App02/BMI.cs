using ConsoleAppProject.Helpers;
using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    ///<summary>
    ///Two unit systems measuring weight and height
    ///</summary>

    public enum UnitSystems
    {
        Metric,
        imperial
    }
    /// <summary>
    /// The Class contains methods for calculating 
    /// the user's BMI (Body Mass Index) using 
    /// imperial or metric units.
    /// This Project has been modified by:
    /// Keegan De souza 01/03/2023
    /// </summary>
    public class BMI
    {
        public const double Underweight = 18.5;
        public const double NormalRange = 24.9;
        public const double Overweight = 29.9;

        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        public double Index { get; set; }

        ///Public Attributes used in this BMI calculator
        ///Metric Details

        public double Kilograms { get; set; }
        public double Centimeters { get; set; }


        ///Imperial Details

        public int Stones { get; set; }
        public int pounds { get; set; }

        public int Feet { get; set; }
        public int Inches { get; set; }

        public UnitSystems Unitsystems
        {
            get => default;
        }

        private double meters;
        ///<Summary>
        ///Prompt the user to select Imperial or Metric
        ///Units. Input the users height and weight and 
        ///then calculate their BMI value. Output which 
        ///weight category they fall into.
        ///</Summary>
        
        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");
            UnitSystems unitSystem = SelectUnits();
            
            if (unitSystem == UnitSystems.Metric)
            {
                InputMetricDetails();
                CalculateMetricBMI();
                GetHealthMessage();
            }
            else
            {
                InputImperialDetails();
                CalculateImperialBMI();
                GetHealthMessage();
            }

           
            
            ///This code outputs the bam message as a string
            GetBameMessage();
        }

        ///Calculate method used to return to the index 
        public void CalculateMetricBMI()
        {
            meters = Centimeters / 100;
            Index = Kilograms / (meters * meters);
            Console.WriteLine($" {Index}");
        }

        public void CalculateImperialBMI()
        {
            Inches += Feet * InchesInFeet;
            pounds += Stones * PoundsInStones;

            Index = (double)pounds * 703 / (Inches * Inches);
        }

        ///<summary>
        ///Prompts the user to select imperial or metric 
        ///units for entering their weight and height 
        ///</summary>
        private UnitSystems SelectUnits()
        {
            string[] choices = new string[]
            {
                "Metric Units",
                "Imperial Units"
            };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                return UnitSystems.Metric;
            }
            else return UnitSystems.imperial;
        }

        ///<summary>
        ///Input the users height in feet and inches and 
        ///their weight in stones and pounds
        ///</summary>
        
        private void InputImperialDetails()
        {
            Console.WriteLine();
            Console.Write(" Enter your height to the nearest feet and inches");
            Console.WriteLine();

            Feet = (int)ConsoleHelper.InputNumber(" Enter your height in feet > ");
            Inches = (int)ConsoleHelper.InputNumber(" Enter your height in inches > ");

            Console.WriteLine();
            Console.Write(" Enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Stones = (int)ConsoleHelper.InputNumber(" Enter your weight in stones > ");
            pounds = (int)ConsoleHelper.InputNumber(" Enter your weight in pounds > ");
        }

        ///<summary>
        ///Input the users height in meters and 
        ///their weight in Kilograms
        ///</summary>
        
        private void InputMetricDetails()
        {
            Centimeters = ConsoleHelper.InputNumber(
                " \n Enter your height in Centimeters > ");

            Kilograms = ConsoleHelper.InputNumber(
                " \n Enter your weight in kilograms > ");

        }

        ///<summary>
        ///Once the user has entered their weight,height etc then the if statments checks and 
        ///Output the users BMI and their weight
        ///category from underweight to obese.
        ///</summary>
        public string GetHealthMessage()
        {
            if (Index < Underweight)
            {
                Console.WriteLine($"\n Your BMI is {Index:0.00}, " +
                    $"You are underweight! ");
            }
            else if (Index <= NormalRange)
            {
                Console.WriteLine($"\n Your BMI is {Index:0.00}, " +
                   $"You are in the normal range! ");
            }
            else if (Index <= Overweight)
            {
                Console.WriteLine($"\n Your BMI is {Index:0.00}, " +
                    $"You are overweight! ");
            }
            else if (Index <= ObeseLevel1)
            {
                Console.WriteLine($"\n Your BMI is {Index:0.00}, " +
                    $"You are obese class I ");
            }
            else if (Index <= ObeseLevel2)
            {
                Console.WriteLine($"\n Your BMI is {Index:0.00}, " +
                    $"You are obese class II ");
            }
            else if (Index <= ObeseLevel3)
            {
                Console.WriteLine($"\n Your BMI is {Index:0.00}, " +
                    $"You are obese class III ");
            }
            else
            {
                Console.WriteLine($"\n Your BMI is {Index:0.00}, " +
                    $"You are obese class III ");
            }
            return Convert.ToString(Index);

        }

        ////<summary>
        ///Output a message for BAME users who are
        ///at higher risk 
        ////</summary>
        public string GetBameMessage()
        {
            ConsoleHelper.OutputTitle("If you are Black, Asian or other minority \n ethnic groups, you have a higher risk \n" +
                "\n Adults 23.0 or more are at increased risk \n Adults 27.5 or more are at increased risk");

            Console.ReadLine();
            return null;
        }
    }
}
