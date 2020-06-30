using System;

namespace LorinthsLair.UnitConverter
{
    /// <summary>
    /// Utilities class.
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// Format double number to show specified amount of decimal numbers.
        /// </summary>
        /// <param name="numberToFormat">
        /// Number to format.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted number.
        /// </returns>
        /// <remarks>
        /// Invoking a method with negative or not specified value of decimalPlaces argument
        /// will result returning unformated number, just converted to string.
        /// </remarks>
        public static string FormatDouble(double numberToFormat, int decimalPlaces = -1)
        {
            if (decimalPlaces < 0)
            {
                return $"{numberToFormat}".Replace(',', '.');
            }

            numberToFormat = RoundCloserToZero(numberToFormat, decimalPlaces);

            return numberToFormat.ToString($"F{decimalPlaces}").Replace(',', '.'); //make sure it will only show specified number od decimal places
        }

        /// <summary>
        /// Round number to closer to zero with specified amount of decimal numbers.
        /// </summary>
        /// <param name="numberToRound">
        /// Number to be rounded.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Rounded number.
        /// </returns>
        public static double RoundCloserToZero(double numberToRound, int decimalPlaces)
        {
            double poweredTen = Math.Pow(10, decimalPlaces);

            numberToRound *= poweredTen;
            numberToRound = (numberToRound >= 0) ? Math.Floor(numberToRound) : Math.Ceiling(numberToRound);
            numberToRound /= poweredTen;

            return numberToRound;
        }
    }
}
