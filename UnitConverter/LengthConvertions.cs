using System;

namespace UnitConverter
{
    /// <summary>
    /// Length unit convertions
    /// </summary>
    public class LengthConvertions
    {
        private const double FootToMeterRatio = 0.3048;
        private const double InchToCentiMeterRatio = 2.54;
        private const double MileToKilometerRatio = 1.609344;

        /// <summary>
        /// Converts meters to feet.
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
        /// Converts feet to meters.
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

        public static double ConvertCentimetersToInches(double centimeters)
        {
            return centimeters / InchToCentiMeterRatio;
        }

        public static double ConvertInchesToCentimeters(double inches)
        {
            return inches * InchToCentiMeterRatio;
        }

        //mile - mi
        public static double ConvertKilometersToMiles(double kilometers)
        {
            return kilometers / MileToKilometerRatio;
        }

        public static double ConvertMilesToKilometers(double miles)
        {
            return miles * MileToKilometerRatio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LengthInCentimeters"></param>
        /// <param name="decimalPlaces">Accuracy</param>
        /// <returns></returns>
        public static string ParseCentimetersToFeet(string LengthInCentimeters, int decimalPlaces = 0)
        {
            double centimeters = double.Parse(LengthInCentimeters.ToLower().Replace("cm", "").Replace('.', ',').Trim());
            double inches = ConvertCentimetersToInches(centimeters);
            int feet = (int)inches / 12;
            inches -= feet * 12;

            return $"{feet}'{Utilities.FormatDouble(inches, decimalPlaces)}\"";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LengthInFeet"></param>
        /// <param name="decimalPlaces">Accuracy</param>
        /// <returns></returns>
        public static string ParseFeetToCentimeters(string LengthInFeet, int decimalPlaces = 2)
        {
            string[] splittedLength = LengthInFeet.Trim().Replace("\"", "").Split('\'');
            int feet = int.Parse(splittedLength[0]);
            int inches = int.Parse(splittedLength[1]);

            double groundTruth = ConvertInchesToCentimeters(feet * 12 + inches);

            string result = $"{Utilities.FormatDouble(groundTruth, decimalPlaces)}cm";

            return result;
        }
    }
}
