# **Simple unit converter.**

[![NuGet version (LorinthsLair.UnitConverter)](https://img.shields.io/nuget/v/LorinthsLair.UnitConverter.svg?style=flat-square)](https://www.nuget.org/packages/LorinthsLair.UnitConverter/)

## **Version 2.0.0 changed the namespace from UnitConverter to LorinthsLair.UnitConverter**

## **Convertions added in version 2.0.0 of NuGet package.**
- **SpeedConverter**
	- `public static double ConvertMetersPerSecondToKilometersPerHour(double metersPerSecond)`
	- `public static double ConvertKilometersPerHourToMetersPerSecond(double kilometersPerHour)`
	- `public static double ConvertKilometersPerHourToMilesPerHour(double kilometersPerHour)`
	- `public static double ConvertMilesPerHourToKilometersPerHour(double milesPerHour)`
	- `public static string ParseMetersPerSecondToKilometersPerHour(string speedInMetersPerSecond, int decimalPlaces = 0)`
	- `public static string ParseKilometersPerHourToMetersPerSecond(string speedInKilometersPerHour, int decimalPlaces = 0)`
	- `public static string ParseKilometersPerHourToMilesPerHour(string speedInKilometersPerHour, int decimalPlaces = 0)`
	- `public static string ParseMilesPerHourToKilometersPerHour(string speedInMilesPerHour, int decimalPlaces = 0)`
- **TimeConverter**
	- `public static double ConvertSecondsToMinutes(double seconds)`
	- `public static double ConvertMinutesToSeconds(double minutes)`
	- `public static double ConvertMinutesToHours(double minutes)`
	- `public static double ConvertHoursToMinutes(double hours)`

## **Convertions supported in version 1.0.0 of NuGet package.**
- **LengthConverter**
	- `public static double ConvertMetersToFeet(double meters)`
	- `public static double ConvertFeetToMeters(double feet)`
	- `public static double ConvertCentimetersToInches(double centimeters)`
	- `public static double ConvertInchesToCentimeters(double inches)`
	- `public static double ConvertKilometersToMiles(double kilometers)`
	- `public static double ConvertMilesToKilometers(double miles)`
	- `public static string ParseCentimetersToFeet(string lengthInCentimeters, int decimalPlaces = 0)`
	- `public static string ParseFeetToCentimeters(string lengthInFeet, int decimalPlaces = 2)`
	- `public static string ParseKilometersToMiles(string lengthInKilometers, int decimalPlaces = 2)`
	- `public static string ParseMilesToKilometers(string lengthInMiles, int decimalPlaces = 2)`
- **WeightConverter**
	- `public static double ConvertKilogramsToPounds(double kilograms)`
	- `public static double ConvertPoundsToKilograms(double pounds)`
	- `public static double ConvertKilogramsToOunces(double kilograms)`
	- `public static double ConvertOuncesToKilograms(double ounces)`
	- `public static double ConvertGramsToOunces(double grams)`
	- `public static double ConvertOuncesToGrams(double ounces)`
	- `public static string ParseKilogramsToPounds(string weightInKilograms, int decimalPlaces = 2)`
	- `public static string ParsePoundsToKilograms(string weightInPounds, int decimalPlaces = 3)`
- **TemperatureConverter**
	- `public static double ConvertCelsiusToFahrenheit(double celsius)`
	- `public static double ConvertFahrenheitToCelsius(double fahrenheit)`
	- `public static string ParseCelsiusToFahrenheit(string celsius, int decimalPlaces = 2)`
	- `public static string ParseFahrenheitToCelsius(string fahrenheit, int decimalPlaces = 2)`
- **Utilities**
	- `public static string FormatDouble(double numberToFormat, int decimalPlaces = -1)`
	- `public static double RoundCloserToZero(double numberToRound, int decimalPlaces)`