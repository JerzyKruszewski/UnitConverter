using System;
using NUnit.Framework;

namespace UnitConverter.UnitTests
{
    [TestFixture]
    public class WeightConverterTests
    {
        [Test]
        [TestCase(100, 220.4622621848)]
        public void ConvertKilogramsToPounds_WhenCalled_ReturnsWeightInPounds(double kilograms, double expectedResult)
        {
            Assert.AreEqual(expectedResult, WeightConverter.ConvertKilogramsToPounds(kilograms), 0.00000001);
        }

        [Test]
        [TestCase(220.4622621848, 100)]
        public void ConvertPoundsToKilograms_WhenCalled_ReturnsWeightInKilograms(double pounds, double expectedResult)
        {
            Assert.AreEqual(expectedResult, WeightConverter.ConvertPoundsToKilograms(pounds), 0.00000001);
        }

        [Test]
        [TestCase(1.0, 35.273961949568)]
        public void ConvertKilogramsToOunces_WhenCalled_ReturnsWeightInOunces(double kilograms, double expectedResult)
        {
            Assert.AreEqual(expectedResult, WeightConverter.ConvertKilogramsToOunces(kilograms), 0.00000001);
        }

        [Test]
        [TestCase(35.273961949568, 1.0)]
        public void ConvertOuncesToKilograms_WhenCalled_ReturnsWeightInKilograms(double ounces, double expectedResult)
        {
            Assert.AreEqual(expectedResult, WeightConverter.ConvertOuncesToKilograms(ounces), 0.00000001);
        }

        [Test]
        [TestCase(1.0, 0.0352739619)]
        public void ConvertGramsToOunces_WhenCalled_ReturnsWeightInOunces(double grams, double expectedResult)
        {
            Assert.AreEqual(expectedResult, WeightConverter.ConvertGramsToOunces(grams), 0.00000001);
        }

        [Test]
        [TestCase(1.0, 28.349523125)]
        public void ConvertOuncesToGrams_WhenCalled_ReturnsWeightInGrams(double ounces, double expectedResult)
        {
            Assert.AreEqual(expectedResult, WeightConverter.ConvertOuncesToGrams(ounces), 0.00000001);
        }

        [Test]
        [TestCase("2.54c")]
        [TestCase("Lorem Ipsum")]
        [TestCase("2cm")]
        [TestCase("")]
        public void ParseKilogramsToPounds_WhenCalledWithNotParseableArgument_ThrowsFormatException(string weightInKilograms)
        {
            Assert.Throws<FormatException>(() => WeightConverter.ParseKilogramsToPounds(weightInKilograms));
        }

        [Test]
        [TestCase("100.0kg", "220.462lbs", 3)]
        [TestCase("100,0", "220.46lbs", 2)]
        public void ParseKilogramsToPounds_WhenCalled_ReturnsFormatedWeightInPounds(string weightInKilograms, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, WeightConverter.ParseKilogramsToPounds(weightInKilograms, decimalPlaces));
        }

        [Test]
        [TestCase("2.54c")]
        [TestCase("Lorem Ipsum")]
        [TestCase("2cm")]
        [TestCase("")]
        public void ParsePoundsToKilograms_WhenCalledWithNotParseableArgument_ThrowsFormatException(string weightInPounds)
        {
            Assert.Throws<FormatException>(() => WeightConverter.ParsePoundsToKilograms(weightInPounds));
        }

        [Test]
        [TestCase("220.462lbs", "99kg", 0)]
        [TestCase("220,462", "99.9kg", 1)]
        public void ParsePoundsToKilograms_WhenCalled_ReturnsFormatedWeightInKilograms(string weightInPounds, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, WeightConverter.ParsePoundsToKilograms(weightInPounds, decimalPlaces));
        }
    }
}
