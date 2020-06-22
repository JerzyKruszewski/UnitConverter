using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    public class TemperatureConvertions
    {
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return 9 * celsius / 5 + 32;
        }

        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return 5 * (fahrenheit - 32) / 9;
        }

        public static string ParseCelsiusToFahrenheit(string celsius, int decimalPlaces = 2)
        {
            double celsiusDegrees = double.Parse(celsius.Trim().Replace('.', ',').Replace("°C", ""));
            double fahrenheitDegrees = ConvertCelsiusToFahrenheit(celsiusDegrees);

            return $"{Utilities.FormatDouble(fahrenheitDegrees, decimalPlaces)}°F";
        }

        public static string ParseFahrenheitToCelsius(string fahrenheit, int decimalPlaces = 2)
        {
            double fahrenheitDegrees = double.Parse(fahrenheit.Trim().Replace('.', ',').Replace("°F", ""));
            double celsiusDegrees = ConvertFahrenheitToCelsius(fahrenheitDegrees);

            return $"{Utilities.FormatDouble(celsiusDegrees, decimalPlaces)}°C";
        }
    }
}
