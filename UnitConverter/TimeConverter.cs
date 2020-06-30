namespace LorinthsLair.UnitConverter
{
    /// <summary>
    /// Time units convertions
    /// </summary>
    public class TimeConverter
    {
        /// <summary>
        /// Converts given time in seconds to minutes.
        /// </summary>
        /// <param name="seconds">
        /// Time in seconds to convert.
        /// </param>
        /// <returns>
        /// Converted time to minutes.
        /// </returns>
        public static double ConvertSecondsToMinutes(double seconds)
        {
            return seconds / 60;
        }

        /// <summary>
        /// Converts given time in minutes to seconds.
        /// </summary>
        /// <param name="minutes">
        /// Time in minutes to convert.
        /// </param>
        /// <returns>
        /// Converted time to seconds.
        /// </returns>
        public static double ConvertMinutesToSeconds(double minutes)
        {
            return minutes * 60;
        }

        /// <summary>
        /// Converts given time in minutes to hours.
        /// </summary>
        /// <param name="minutes">
        /// Time in minutes to convert.
        /// </param>
        /// <returns>
        /// Converted time to hours.
        /// </returns>
        public static double ConvertMinutesToHours(double minutes)
        {
            return minutes / 60;
        }

        /// <summary>
        /// Converts given time in hours to minutes.
        /// </summary>
        /// <param name="hours">
        /// Time in hours to convert.
        /// </param>
        /// <returns>
        /// Converted time to minutes.
        /// </returns>
        public static double ConvertHoursToMinutes(double hours)
        {
            return hours * 60;
        }
    }
}
