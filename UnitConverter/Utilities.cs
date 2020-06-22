using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    public class Utilities
    {
        public static string FormatDouble(double numberToFormat, int decimalPlaces = -1)
        {
            if (decimalPlaces < 0)
            {
                return $"{numberToFormat}";
            }

            numberToFormat = RoundCloserToZero(numberToFormat, decimalPlaces);

            return numberToFormat.ToString($"F{decimalPlaces}").Replace(',', '.'); //make sure it will only show specified number od decimal places
        }

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
