using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    /// <summary>
    /// Temperature units convertions.
    /// </summary>
    public class TemperatureConverter
    {
        /// <summary>
        /// Converts given temperature in Celsius to Fahrenheit.
        /// </summary>
        /// <param name="celsius">
        /// Temperature in Celsius degrees to convert.
        /// </param>
        /// <returns>
        /// Converted temperature to Fahrenheit degrees.
        /// </returns>
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return 9 * celsius / 5 + 32;
        }

        /// <summary>
        /// Converts given temperature in Fahrenheit to Celsius.
        /// </summary>
        /// <param name="fahrenheit">
        /// Temperature in Fahrenheit degrees to convert.
        /// </param>
        /// <returns>
        /// Converted temperature to Celsius degrees.
        /// </returns>
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return 5 * (fahrenheit - 32) / 9;
        }

        /// <summary>
        /// Parse temperature in Celsius from string to Fahrenheit.
        /// </summary>
        /// <param name="celsius">
        /// Temperature in Celsius degrees.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted temperature in Fahrenheit degrees.
        /// </returns>
        public static string ParseCelsiusToFahrenheit(string celsius, int decimalPlaces = 2)
        {
            double celsiusDegrees = double.Parse(celsius.Trim().Replace('.', ',').Replace("°C", ""));
            double fahrenheitDegrees = ConvertCelsiusToFahrenheit(celsiusDegrees);

            return $"{Utilities.FormatDouble(fahrenheitDegrees, decimalPlaces)}°F";
        }

        /// <summary>
        /// Parse temperature in Fahrenheit from string to Celsius.
        /// </summary>
        /// <param name="fahrenheit">
        /// Temperature in Fahrenheit degrees.
        /// </param>
        /// <param name="decimalPlaces">
        /// Desired accuracy.
        /// </param>
        /// <returns>
        /// Formatted temperature in Celsius degrees.
        /// </returns>
        public static string ParseFahrenheitToCelsius(string fahrenheit, int decimalPlaces = 2)
        {
            double fahrenheitDegrees = double.Parse(fahrenheit.Trim().Replace('.', ',').Replace("°F", ""));
            double celsiusDegrees = ConvertFahrenheitToCelsius(fahrenheitDegrees);

            return $"{Utilities.FormatDouble(celsiusDegrees, decimalPlaces)}°C";
        }
    }
}
