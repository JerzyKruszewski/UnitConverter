using System;
using NUnit.Framework;

namespace LorinthsLair.UnitConverter.UnitTests
{
    [TestFixture]
    public class SpeedConverterTests
    {
        [Test]
        [TestCase(1, 3.6)]
        public void ConvertMetersPerSecondToKilometersPerHour_WhenCalled_ReturnsSpeedInKilometersPerHour(double metersPerSecond, double expectedResult)
        {
            Assert.AreEqual(expectedResult, SpeedConverter.ConvertMetersPerSecondToKilometersPerHour(metersPerSecond));
        }

        [Test]
        [TestCase(3.6, 1)]
        public void ConvertKilometersPerHourToMetersPerSecond_WhenCalled_ReturnsSpeedInMetersPerSecond(double kilometersPerHour, double expectedResult)
        {
            Assert.AreEqual(expectedResult, SpeedConverter.ConvertKilometersPerHourToMetersPerSecond(kilometersPerHour));
        }

        [Test]
        [TestCase(1.609344, 1.0)]
        public void ConvertKilometersPerHourToMilesPerHour_WhenCalled_ReturnsSpeedInMilesPerHour(double kilometersPerHour, double expectedResult)
        {
            Assert.AreEqual(expectedResult, SpeedConverter.ConvertKilometersPerHourToMilesPerHour(kilometersPerHour));
        }

        [Test]
        [TestCase(1.0, 1.609344)]
        public void ConvertMilesPerHourToKilometersPerHour_WhenCalled_ReturnsSpeedInKilometersPerHour(double milesPerHour, double expectedResult)
        {
            Assert.AreEqual(expectedResult, SpeedConverter.ConvertMilesPerHourToKilometersPerHour(milesPerHour));
        }

        [Test]
        [TestCase("2.54c")]
        [TestCase("Lorem Ipsum")]
        [TestCase("4'11")]
        [TestCase("")]
        public void ParseMetersPerSecondToKilometersPerHour_WhenCalledWithNotParseableArgument_ThrowsFormatException(string speedInMetersPerSecond)
        {
            Assert.Throws<FormatException>(() => SpeedConverter.ParseMetersPerSecondToKilometersPerHour(speedInMetersPerSecond));
        }

        [Test]
        [TestCase("1.0m/sec", "3.6km/h", 1)]
        [TestCase("1m/s", "3.60km/h", 2)]
        [TestCase("1", "3km/h", 0)]
        public void ParseMetersPerSecondToKilometersPerHour_WhenCalled_ReturnsFormatedSpeed(string speedInMetersPerSecond, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, SpeedConverter.ParseMetersPerSecondToKilometersPerHour(speedInMetersPerSecond, decimalPlaces));
        }

        [Test]
        [TestCase("2.54c")]
        [TestCase("Lorem Ipsum")]
        [TestCase("4'11")]
        [TestCase("")]
        public void ParseKilometersPerHourToMetersPerSecond_WhenCalledWithNotParseableArgument_ThrowsFormatException(string speedInKilometersPerHour)
        {
            Assert.Throws<FormatException>(() => SpeedConverter.ParseKilometersPerHourToMetersPerSecond(speedInKilometersPerHour));
        }

        [Test]
        [TestCase("3.60kmh", "1.0m/s", 1)]
        [TestCase("3.6km/h", "1.00m/s", 2)]
        [TestCase("3.6", "1m/s", 0)]
        public void ParseKilometersPerHourToMetersPerSecond_WhenCalled_ReturnsFormatedSpeed(string speedInKilometersPerHour, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, SpeedConverter.ParseKilometersPerHourToMetersPerSecond(speedInKilometersPerHour, decimalPlaces));
        }

        [Test]
        [TestCase("2.54c")]
        [TestCase("Lorem Ipsum")]
        [TestCase("4'11")]
        [TestCase("")]
        public void ParseKilometersPerHourToMilesPerHour_WhenCalledWithNotParseableArgument_ThrowsFormatException(string speedInKilometersPerHour)
        {
            Assert.Throws<FormatException>(() => SpeedConverter.ParseKilometersPerHourToMilesPerHour(speedInKilometersPerHour));
        }

        [Test]
        [TestCase("1.609344km/h", "1.0MPH", 1)]
        [TestCase("1.609344km/h", "1MPH", 0)]
        [TestCase("1.609344KMH", "1.0MPH", 1)]
        public void ParseKilometersPerHourToMilesPerHour_WhenCalled_ReturnsFormatedSpeed(string speedInKilometersPerHour, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, SpeedConverter.ParseKilometersPerHourToMilesPerHour(speedInKilometersPerHour, decimalPlaces));
        }

        [Test]
        [TestCase("2.54c")]
        [TestCase("Lorem Ipsum")]
        [TestCase("2cm")]
        [TestCase("")]
        public void ParseMilesPerHourToKilometersPerHour_WhenCalledWithNotParseableArgument_ThrowsFormatException(string speedInMilesPerHour)
        {
            Assert.Throws<FormatException>(() => SpeedConverter.ParseMilesPerHourToKilometersPerHour(speedInMilesPerHour));
        }

        [Test]
        [TestCase("1.0", "1.609344km/h", 6)]
        [TestCase("1.0mi/h", "1.609344km/h", 6)]
        [TestCase("1.0MPH", "1.609km/h", 3)]
        public void ParseMilesPerHourToKilometersPerHour_WhenCalled_ReturnsFormatedSpeed(string speedInMilesPerHour, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, SpeedConverter.ParseMilesPerHourToKilometersPerHour(speedInMilesPerHour, decimalPlaces));
        }
    }
}
