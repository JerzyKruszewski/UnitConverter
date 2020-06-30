using System;
using NUnit.Framework;

namespace LorinthsLair.UnitConverter.UnitTests
{
    [TestFixture]
    public class TimeConverterTests
    {
        [Test]
        [TestCase(60, 1)]
        [TestCase(15.0, 0.25)]
        public void ConvertSecondsToMinutes_WhenCalled_ReturnsTimeInMinutes(double seconds, double expectedResult)
        {
            Assert.AreEqual(expectedResult, TimeConverter.ConvertSecondsToMinutes(seconds));
        }

        [Test]
        [TestCase(1.0, 60)]
        [TestCase(0.25, 15.0)]
        public void ConvertMinutesToSeconds_WhenCalled_ReturnsTimeInSeconds(double minutes, double expectedResult)
        {
            Assert.AreEqual(expectedResult, TimeConverter.ConvertMinutesToSeconds(minutes));
        }

        [Test]
        [TestCase(60, 1)]
        [TestCase(15.0, 0.25)]
        public void ConvertMinutesToHours_WhenCalled_ReturnsTimeInHours(double minutes, double expectedResult)
        {
            Assert.AreEqual(expectedResult, TimeConverter.ConvertMinutesToHours(minutes));
        }

        [Test]
        [TestCase(1.0, 60)]
        [TestCase(0.25, 15.0)]
        public void ConvertHoursToMinutes_WhenCalled_ReturnsTimeInMinutes(double hours, double expectedResult)
        {
            Assert.AreEqual(expectedResult, TimeConverter.ConvertHoursToMinutes(hours));
        }
    }
}
