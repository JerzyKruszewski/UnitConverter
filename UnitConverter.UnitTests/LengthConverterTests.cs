using NUnit.Framework;

namespace UnitConverter.UnitTests
{
    [TestFixture]
    public class LengthConverterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Accuracy to the 10th decimal place
        [Test]
        [TestCase(1.0, 3.280839895013123)]
        [TestCase(0.3048, 1.0)]
        public void ConvertMetersToFeet_WhenCalled_ReturnsLengthInFeet(double meters, double expectedResult)
        {
            Assert.AreEqual(expectedResult, LengthConverter.ConvertMetersToFeet(meters), 0.0000000001);
        }

        // Accuracy to the 10th decimal place
        [Test]
        [TestCase(3.280839895013123, 1.0)]
        [TestCase(1.0, 0.3048)]
        public void ConvertFeetToMeters_WhenCalled_ReturnsLengthInMeters(double feet, double expectedResult)
        {
            Assert.AreEqual(expectedResult, LengthConverter.ConvertFeetToMeters(feet), 0.0000000001);
        }

        [Test]
        [TestCase(1.0, 0.3937007874)]
        [TestCase(2.54, 1.0)]
        public void ConvertCentimetersToInches_WhenCalled_ReturnsLengthInInches(double centimeters, double expectedResult)
        {
            Assert.AreEqual(expectedResult, LengthConverter.ConvertCentimetersToInches(centimeters), 0.0000000001);
        }

        [Test]
        [TestCase(0.3937007874, 1.0)]
        [TestCase(1.0, 2.54)]
        public void ConvertInchesToCentimeters_WhenCalled_ReturnsLengthInCentimeters(double inches, double expectedResult)
        {
            Assert.AreEqual(expectedResult, LengthConverter.ConvertInchesToCentimeters(inches), 0.0000000001);
        }

        [Test]
        [TestCase(1.609344, 1.0)]
        public void ConvertKilometersToMiles_WhenCalled_ReturnsLengthInMiles(double kilometers, double expectedResult)
        {
            Assert.AreEqual(expectedResult, LengthConverter.ConvertKilometersToMiles(kilometers), 0.0000000001);
        }

        [Test]
        [TestCase(1.0, 1.609344)]
        public void ConvertMilesToKilometers_WhenCalled_ReturnsLengthInKilometers(double miles, double expectedResult)
        {
            Assert.AreEqual(expectedResult, LengthConverter.ConvertMilesToKilometers(miles), 0.0000000001);
        }

        [Test]
        [TestCase("2.54c")]
        [TestCase("Lorem Ipsum")]
        [TestCase("4'11")]
        [TestCase("")]
        public void ParseCentimetersToFeet_WhenCalledWithNotParseableArgument_ThrowsFormatException(string LengthInCentimeters)
        {
            Assert.Throws<System.FormatException>(() => LengthConverter.ParseCentimetersToFeet(LengthInCentimeters));
        }

        [Test]
        [TestCase("2.54cm", "0'1\"", 0)]
        [TestCase("30.40cm", "0'11\"", 0)]
        [TestCase("32cm", "1'0\"", 0)]
        [TestCase("180,0cm", "5'10\"", 0)]
        [TestCase("2.54cm", "0'1.0\"", 1)]
        [TestCase("2.54cm", "0'1.000\"", 3)]
        public void ParseCentimetersToFeet_WhenCalled_ReturnsFormatedLength(string LengthInCentimeters, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, LengthConverter.ParseCentimetersToFeet(LengthInCentimeters, decimalPlaces));
        }

        [Test]
        [TestCase("0'1\"", "2.54cm", 2)]
        [TestCase("0'11\"", "27.94cm", 2)]
        [TestCase("1'0\"", "30.48cm", 2)]
        [TestCase("5'10\"", "177.80cm", 2)]
        [TestCase("5'10\"", "177.8cm", 1)]
        [TestCase("5'10\"", "177cm", 0)]
        public void ParseFeetToCentimeters_WhenCalled_ReturnsFormatedLength(string LengthInFeet, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, LengthConverter.ParseFeetToCentimeters(LengthInFeet, decimalPlaces));
        }
    }
}