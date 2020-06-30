namespace LorinthsLair.UnitConverter
{
    /// <summary>
    /// Speed units convertions
    /// </summary>
    public class SpeedConverter
    {
        /// <summary>
        /// Converts given speed in meters per second to kilometers per hour.
        /// </summary>
        /// <param name="metersPerSecond">
        /// Speed in meters per second to convert.
        /// </param>
        /// <returns>
        /// Converted speed to kilometers per hour.
        /// </returns>
        public static double ConvertMetersPerSecondToKilometersPerHour(double metersPerSecond)
        {
            return metersPerSecond * 3600 / 1000;
        }

        /// <summary>
        /// Converts given speed in kilometers per hour to meters per second.
        /// </summary>
        /// <param name="kilometersPerHour">
        /// Speed in kilometers per hour to convert.
        /// </param>
        /// <returns>
        /// Converted speed to meters per second.
        /// </returns>
        public static double ConvertKilometersPerHourToMetersPerSecond(double kilometersPerHour)
        {
            return kilometersPerHour * 1000 / 3600;
        }

        /// <summary>
        /// Converts given speed in kilometers per hour to miles per hour.
        /// </summary>
        /// <param name="kilometersPerHour">
        /// Speed in kilometers per hour to convert.
        /// </param>
        /// <returns>
        /// Converted speed to miles per hour.
        /// </returns>
        public static double ConvertKilometersPerHourToMilesPerHour(double kilometersPerHour)
        {
            // Because unit of time stays the same, I can only convert length unit
            return LengthConverter.ConvertKilometersToMiles(kilometersPerHour);
        }

        /// <summary>
        /// Converts given speed in miles per hour to kilometers per hour.
        /// </summary>
        /// <param name="milesPerHour">
        /// Speed in miles per hour to convert.
        /// </param>
        /// <returns>
        /// Converted speed to kilometers per hour.
        /// </returns>
        public static double ConvertMilesPerHourToKilometersPerHour(double milesPerHour)
        {
            return LengthConverter.ConvertMilesToKilometers(milesPerHour);
        }

        /// <summary>
        /// Parse speed in meters per second from string to kilometers per hour.
        /// </summary>
        /// <param name="speedInMetersPerSecond">
        /// Speed in meters per second.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted speed in kilometers per hour.
        /// </returns>
        public static string ParseMetersPerSecondToKilometersPerHour(string speedInMetersPerSecond, int decimalPlaces = 0)
        {
            double metersPerSecond = double.Parse(speedInMetersPerSecond.ToLower().Replace("m/sec", "").Replace("m/s", "").Replace('.', ',').Trim());
            double kilometersPerHour = ConvertMetersPerSecondToKilometersPerHour(metersPerSecond);

            return $"{Utilities.FormatDouble(kilometersPerHour, decimalPlaces)}km/h";
        }

        /// <summary>
        /// Parse speed in kilometers per hour from string to meters per second.
        /// </summary>
        /// <param name="speedInKilometersPerHour">
        /// Speed in kilometers per hour.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted speed in meters per second.
        /// </returns>
        public static string ParseKilometersPerHourToMetersPerSecond(string speedInKilometersPerHour, int decimalPlaces = 0)
        {
            double kilometersPerHour = double.Parse(speedInKilometersPerHour.ToLower().Replace("km/h", "").Replace("kmh", "").Replace('.', ',').Trim());
            double metersPerSecond = ConvertKilometersPerHourToMetersPerSecond(kilometersPerHour);

            return $"{Utilities.FormatDouble(metersPerSecond, decimalPlaces)}m/s";
        }

        /// <summary>
        /// Parse speed in kilometers per hour from string to miles per hour.
        /// </summary>
        /// <param name="speedInKilometersPerHour">
        /// Speed in kilometers per hour.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted speed in miles per hour.
        /// </returns>
        public static string ParseKilometersPerHourToMilesPerHour(string speedInKilometersPerHour, int decimalPlaces = 0)
        {
            double kilometersPerHour = double.Parse(speedInKilometersPerHour.ToLower().Replace("km/h", "").Replace("kmh", "").Replace('.', ',').Trim());
            double milesPerHour = ConvertKilometersPerHourToMilesPerHour(kilometersPerHour);

            return $"{Utilities.FormatDouble(milesPerHour, decimalPlaces)}MPH";
        }

        /// <summary>
        /// Parse speed in miles per hour from string to kilometers per hour.
        /// </summary>
        /// <param name="speedInMilesPerHour">
        /// Speed in miles per hour.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted speed in kilometers per hour.
        /// </returns>
        public static string ParseMilesPerHourToKilometersPerHour(string speedInMilesPerHour, int decimalPlaces = 0)
        {
            double milesPerHour = double.Parse(speedInMilesPerHour.ToLower().Replace("mph", "").Replace("mi/h", "").Replace('.', ',').Trim());
            double kilometersPerHour = ConvertMilesPerHourToKilometersPerHour(milesPerHour);

            return $"{Utilities.FormatDouble(kilometersPerHour, decimalPlaces)}km/h";
        }
    }
}
