using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    public class WeightConvertions
    {
        private const double PoundsToKilogramsRatio = 0.45359237;
        private const double OuncesToGramsRatio = 28.349523125;

        public static double ConvertKilogramsToPounds(double kilograms)
        {
            return kilograms / PoundsToKilogramsRatio;
        }

        public static double ConvertPoundsToKilograms(double pounds)
        {
            return pounds * PoundsToKilogramsRatio;
        }

        public static double ConvertKilogramsToOunces(double kilograms)
        {
            return kilograms / PoundsToKilogramsRatio * 16;
        }

        public static double ConvertOuncesToKilograms(double ounces)
        {
            return ounces * PoundsToKilogramsRatio / 16;
        }

        public static double ConvertGramsToOunces(double grams)
        {
            return grams / OuncesToGramsRatio;
        }

        public static double ConvertOuncesToGrams(double ounces)
        {
            return ounces * OuncesToGramsRatio;
        }

        public static string ParseKilogramsToPounds(string weightInKilograms, int decimalPlaces = 2)
        {
            double kilograms = double.Parse(weightInKilograms.ToLower().Replace("kg", "").Replace('.', ',').Trim());
            double pounds = ConvertKilogramsToPounds(kilograms);

            return $"{Utilities.FormatDouble(pounds, decimalPlaces)}lbs";
        }

        public static string ParsePoundsToKilograms(string weightInPounds, int decimalPlaces = 3)
        {
            double pounds = double.Parse(weightInPounds.ToLower().Replace("lbs", "").Replace('.', ',').Trim());
            double kilograms = ConvertPoundsToKilograms(pounds);

            return $"{Utilities.FormatDouble(kilograms, decimalPlaces)}kg";
        }
    }
}
