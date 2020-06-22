using NUnit.Framework;

namespace UnitConverter.UnitTests
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0, 32)]
        [TestCase(1, 33.8)]
        [TestCase(37.777777777777, 100)]
        public void ConvertCelsiusToFahrenheit_WhenCalled_ReturnsTemperatureInFahrenheit(double celsius, double expectedResult)
        {
            Assert.AreEqual(expectedResult, TemperatureConverter.ConvertCelsiusToFahrenheit(celsius), 0.0000000001);
        }

        [Test]
        [TestCase(32, 0)]
        [TestCase(33.8, 1)]
        [TestCase(100, 37.777777777777)]
        public void ConvertFahrenheitToCelsius_WhenCalled_ReturnsTemperatureInCelsius(double fahrenheit, double expectedResult)
        {
            Assert.AreEqual(expectedResult, TemperatureConverter.ConvertFahrenheitToCelsius(fahrenheit), 0.0000000001);
        }

        [Test]
        [TestCase("0", "32.0°F", 1)]
        public void ParseCelsiusToFahrenheit_WhenCalled_ReturnsTemperatureInFahrenheit(string celsius, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, TemperatureConverter.ParseCelsiusToFahrenheit(celsius, decimalPlaces));
        }

        [Test]
        [TestCase("32.0°F", "0.00°C", 2)]
        public void ParseFahrenheitToCelsius_WhenCalled_ReturnsTemperatureInCelsius(string fahrenheit, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, TemperatureConverter.ParseFahrenheitToCelsius(fahrenheit, decimalPlaces));
        }
    }
}
