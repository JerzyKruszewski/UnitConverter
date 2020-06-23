using System;

namespace UnitConverter
{
    /// <summary>
    /// Length units convertions
    /// </summary>
    public class LengthConverter
    {
        private const double FootToMeterRatio = 0.3048;
        private const double InchToCentiMeterRatio = 2.54;
        private const double MileToKilometerRatio = 1.609344;

        /// <summary>
        /// Converts given length in meters to feet.
        /// </summary>
        /// <param name="meters">
        /// Length in meters to convert.
        /// </param>
        /// <returns>
        /// Converted Length to feet.
        /// </returns>
        public static double ConvertMetersToFeet(double meters)
        {
            return meters / FootToMeterRatio;
        }

        /// <summary>
        /// Converts given length in feet to meters.
        /// </summary>
        /// <param name="feet">
        /// Length in feet to convert.
        /// </param>
        /// <returns>
        /// Converted Length to meters.
        /// </returns>
        public static double ConvertFeetToMeters(double feet)
        {
            return feet * FootToMeterRatio;
        }

        /// <summary>
        /// Converts given length in centimeters to inches.
        /// </summary>
        /// <param name="centimeters">
        /// Length in centimeters to convert.
        /// </param>
        /// <returns>
        /// Converted length in inches.
        /// </returns>
        public static double ConvertCentimetersToInches(double centimeters)
        {
            return centimeters / InchToCentiMeterRatio;
        }

        /// <summary>
        /// Converts given length in inches to centimeters.
        /// </summary>
        /// <param name="inches">
        /// Length in inches to convert.
        /// </param>
        /// <returns>
        /// Converted length in centimeters.
        /// </returns>
        public static double ConvertInchesToCentimeters(double inches)
        {
            return inches * InchToCentiMeterRatio;
        }

        //mile - mi.
        /// <summary>
        /// Converts given length in kilometers to miles.
        /// </summary>
        /// <param name="kilometers">
        /// Length in kilometers to convert.
        /// </param>
        /// <returns>
        /// Converted length in miles.
        /// </returns>
        public static double ConvertKilometersToMiles(double kilometers)
        {
            return kilometers / MileToKilometerRatio;
        }

        /// <summary>
        /// Converts given length in miles to kilometers.
        /// </summary>
        /// <param name="miles">
        /// Length in miles to convert.
        /// </param>
        /// <returns>
        /// Converted length in kilometers.
        /// </returns>
        public static double ConvertMilesToKilometers(double miles)
        {
            return miles * MileToKilometerRatio;
        }

        /// <summary>
        /// Parse length in centimeters from string to feet.
        /// </summary>
        /// <param name="lengthInCentimeters">
        /// Length in centimeters.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted length in feet.
        /// </returns>
        public static string ParseCentimetersToFeet(string lengthInCentimeters, int decimalPlaces = 0)
        {
            double centimeters = double.Parse(lengthInCentimeters.ToLower().Replace("cm", "").Replace('.', ',').Trim());
            double inches = ConvertCentimetersToInches(centimeters);
            int feet = (int)inches / 12;
            inches -= feet * 12;

            return $"{feet}'{Utilities.FormatDouble(inches, decimalPlaces)}\"";
        }

        /// <summary>
        /// Parse length in feet from string to centimeters.
        /// </summary>
        /// <param name="lengthInFeet">
        /// Length in feet.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted length in centimeters.
        /// </returns>
        public static string ParseFeetToCentimeters(string lengthInFeet, int decimalPlaces = 2)
        {
            string[] splittedLength = lengthInFeet.Trim().Replace("\"", "").Split('\'');
            int feet = int.Parse(splittedLength[0]);
            int inches = int.Parse(splittedLength[1]);

            double groundTruth = ConvertInchesToCentimeters(feet * 12 + inches);

            string result = $"{Utilities.FormatDouble(groundTruth, decimalPlaces)}cm";

            return result;
        }
    }
}
