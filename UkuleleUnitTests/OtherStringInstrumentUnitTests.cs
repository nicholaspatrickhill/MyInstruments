using MyInstruments;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;

namespace OtherStringInstrumentUnitTests
{

    public class OtherStringInstrumentNameTest
    {
        [Test]
        public void OtherStringInstrumentNameTestValid()
        {
            // Arrange
            OtherStringInstrument otherStringInstrument = new OtherStringInstrument
            {
                Make = "Martin",
                Model = "T1K"
            };
            string? expected = "Martin T1K";

            // Act
            string? actual = otherStringInstrument.InstrumentName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
    public class OtherStringInstrumentAgeTest
    {
        [Test]
        public void OtherStringInstrumentAgeTestValid()
        {
            // Arrange
            OtherStringInstrument otherStringInstrument = new OtherStringInstrument
            {
                Year = 2000
            };
            int expected = 22;

            // Act
            int actual = otherStringInstrument.InstrumentAge;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
    public class OtherStringInstrumentStringTest
    {
        [Test]
        public void OtherStringInstrumentStringTestValid()
        {
            // Arrange
            OtherStringInstrument otherStringInstrument = new OtherStringInstrument
            {
                StringBrand = "Martin",
                StringType = "Tenor Fluorocarbon",
                StringGauge = "22"
            };
            string? expected = "Martin Tenor Fluorocarbon 22";

            // Act
            string? actual = otherStringInstrument.InstrumentString;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class OtherStringInstrumentPrintTest
    {
        [Test]
        public void OthertringInstrumentTestValid()
        {
            // Arrange
            OtherStringInstrument otherStringInstrument = new OtherStringInstrument
            {
                Make = "Martin",
                Model = "T1K",
                Type = "hollow-body acoustic ukulele",
                Country = "USA",
                Year = 2020,
                Serial = "1234567",
                Color = "Natural Koa",
                Size = "tenor",
                StringBrand = "Martin",
                StringType = "Tenor Fluorocarbon",
                StringGauge = "22"
            };
            string expected = "Your Martin T1K is a hollow-body acoustic ukulele that was made in USA in 2020. " 
                + "It is 2 years old. It is Natural Koa in color. It is a tenor instrument. Its serial number is 1234567. "
                + "It uses Martin Tenor Fluorocarbon 22 gauge strings.";

            // Act
            string actual = $"Your {otherStringInstrument.InstrumentName} is a {otherStringInstrument.Type} that was made in {otherStringInstrument.Country} in {otherStringInstrument.Year}. "
            + $"It is {otherStringInstrument.InstrumentAge} years old. It is {otherStringInstrument.Color} in color. It is a {otherStringInstrument.Size} instrument. Its serial number is {otherStringInstrument.Serial}. "
            + $"It uses {otherStringInstrument.InstrumentString} gauge strings.";

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}