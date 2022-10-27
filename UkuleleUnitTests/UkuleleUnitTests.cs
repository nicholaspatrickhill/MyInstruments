using MyInstruments;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;

namespace UkuleleUnitTests
{
    // Fulfills Feature List Requirement: "Create 3 or more unit tests for your application"

    public class UkuleleNameTest
    {
        [Test]
        public void UkuleleNameTestValid()
        {
            // Arrange
            Ukulele ukulele = new Ukulele
            {
                Make = "Martin",
                Model = "T1K"
            };
            string? expected = "Martin T1K";

            // Act
            string? actual = ukulele.InstrumentName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
    public class UkuleleAgeTest
    {
        [Test]
        public void UkuleleAgeTestValid()
        {
            // Arrange
            Ukulele ukulele = new Ukulele
            {
                Year = 2000
            };
            int expected = 22;

            // Act
            int actual = ukulele.InstrumentAge;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
    public class UkuleleStringTest
    {
        [Test]
        public void UkuleleStringTestValid()
        {
            // Arrange
            Ukulele ukulele = new Ukulele
            {
                StringBrand = "Martin",
                StringType = "Tenor Fluorocarbon",
                StringGauge = "22"
            };
            string? expected = "Martin Tenor Fluorocarbon 22";

            // Act
            string? actual = ukulele.InstrumentString;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class UkulelePrintTest
    {
        [Test]
        public void UkulelePrintTestValid()
        {
            // Arrange
            Ukulele ukulele = new Ukulele
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
                + "It is 2 years old. It is Natural Koa in color. It is a tenor sized instrument. Its serial number is 1234567. "
                + "It uses Martin Tenor Fluorocarbon 22 gauge strings.";

            // Act
            string actual = $"Your {ukulele.InstrumentName} is a {ukulele.Type} that was made in {ukulele.Country} in {ukulele.Year}. "
            + $"It is {ukulele.InstrumentAge} years old. It is {ukulele.Color} in color. It is a {ukulele.Size} sized instrument. Its serial number is {ukulele.Serial}. "
            + $"It uses {ukulele.InstrumentString} gauge strings.";

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}