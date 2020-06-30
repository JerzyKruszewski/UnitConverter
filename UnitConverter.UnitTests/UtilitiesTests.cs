using NUnit.Framework;

namespace LorinthsLair.UnitConverter.UnitTests
{
    [TestFixture]
    public class UtilitiesTests
    {
        [Test]
        [TestCase(10.0, "10", 0)]
        [TestCase(-1, "-1.0000", 4)]
        [TestCase(1, "1.00", 2)]
        [TestCase(1.5, "1.5", -1)]
        public void FormatDouble_WhenCalled_FormatsDoubleNumberWithGivenDecimalPrecision(double numberToFormat, string expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, Utilities.FormatDouble(numberToFormat, decimalPlaces));
        }

        [Test]
        [TestCase(4.997, 4.99, 2)]
        [TestCase(-1.5, -1, 0)]
        [TestCase(1.954719, 1.95471, 5)]
        [TestCase(19, 10, -1)]
        public void RoundCloserToZero_WhenCalled_RoundsDoubleNumberWithGivenDecimalPrecision(double numberToRound, double expectedResult, int decimalPlaces)
        {
            Assert.AreEqual(expectedResult, Utilities.RoundCloserToZero(numberToRound, decimalPlaces));
        }
    }
}
