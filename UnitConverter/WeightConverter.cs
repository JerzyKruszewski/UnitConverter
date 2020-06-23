namespace UnitConverter
{
    /// <summary>
    /// Weight units convertions
    /// </summary>
    public class WeightConverter
    {
        private const double PoundsToKilogramsRatio = 0.45359237;
        private const double OuncesToGramsRatio = 28.349523125;

        /// <summary>
        /// Converts given weight in kilograms to pounds.
        /// </summary>
        /// <param name="kilograms">
        /// Weight in kilograms to convert.
        /// </param>
        /// <returns>
        /// Converted weight to pounds.
        /// </returns>
        public static double ConvertKilogramsToPounds(double kilograms)
        {
            return kilograms / PoundsToKilogramsRatio;
        }

        /// <summary>
        /// Converts given weight in pounds to kilograms.
        /// </summary>
        /// <param name="pounds">
        /// Weight in pounds to convert.
        /// </param>
        /// <returns>
        /// Converted weight to kilograms.
        /// </returns>
        public static double ConvertPoundsToKilograms(double pounds)
        {
            return pounds * PoundsToKilogramsRatio;
        }

        /// <summary>
        /// Converts given weight in kilograms to ounces.
        /// </summary>
        /// <param name="kilograms">
        /// Weight in kilograms to convert.
        /// </param>
        /// <returns>
        /// Converted weight to ounces.
        /// </returns>
        public static double ConvertKilogramsToOunces(double kilograms)
        {
            return kilograms / PoundsToKilogramsRatio * 16;
        }

        /// <summary>
        /// Converts given weight in ounces to kilograms.
        /// </summary>
        /// <param name="ounces">
        /// Weight in ounces to convert.
        /// </param>
        /// <returns>
        /// Converted weight to kilograms.
        /// </returns>
        public static double ConvertOuncesToKilograms(double ounces)
        {
            return ounces * PoundsToKilogramsRatio / 16;
        }

        /// <summary>
        /// Converts given weight in grams to ounces.
        /// </summary>
        /// <param name="grams">
        /// Weight in grams to convert.
        /// </param>
        /// <returns>
        /// Converted weight to ounces.
        /// </returns>
        public static double ConvertGramsToOunces(double grams)
        {
            return grams / OuncesToGramsRatio;
        }

        /// <summary>
        /// Converts given weight in ounces to grams.
        /// </summary>
        /// <param name="ounces">
        /// Weight in ounces to convert.
        /// </param>
        /// <returns>
        /// Converted weight to grams.
        /// </returns>
        public static double ConvertOuncesToGrams(double ounces)
        {
            return ounces * OuncesToGramsRatio;
        }

        /// <summary>
        /// Parse weight in kilograms from string to pounds.
        /// </summary>
        /// <param name="weightInKilograms">
        /// Weight in kilograms.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted weight in pounds.
        /// </returns>
        public static string ParseKilogramsToPounds(string weightInKilograms, int decimalPlaces = 2)
        {
            double kilograms = double.Parse(weightInKilograms.ToLower().Replace("kg", "").Replace('.', ',').Trim());
            double pounds = ConvertKilogramsToPounds(kilograms);

            return $"{Utilities.FormatDouble(pounds, decimalPlaces)}lbs";
        }

        /// <summary>
        /// Parse weight in pounds from string to kilograms.
        /// </summary>
        /// <param name="weightInPounds">
        /// Weight in pounds.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted weight in kilograms.
        /// </returns>
        public static string ParsePoundsToKilograms(string weightInPounds, int decimalPlaces = 3)
        {
            double pounds = double.Parse(weightInPounds.ToLower().Replace("lbs", "").Replace('.', ',').Trim());
            double kilograms = ConvertPoundsToKilograms(pounds);

            return $"{Utilities.FormatDouble(kilograms, decimalPlaces)}kg";
        }
    }
}
