using MyInstruments;

namespace BanjoUnitTests
{
    // Fulfills Feature List Requirement: "Create 3 or more unit tests for your application"

    public class BanjoNameTest
    {
        [Test]
        public void BanjoNameTestValid()
        {
            // Arrange
            Banjo banjo = new Banjo
            {
                Make = "Vega",
                Model = "Long Neck Banjo"
            };
            string? expected = "Vega Long Neck Banjo";

            // Act
            string? actual = banjo.InstrumentName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
    public class BanjoAgeTest
    {
        [Test]
        public void BanjoAgeTestValid()
        {
            // Arrange
            Banjo banjo = new Banjo
            {
                Year = 2000
            };
            int expected = 22;

            // Act
            int actual = banjo.InstrumentAge;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
    public class BanjoStringTest
    {
        [Test]
        public void BanjoStringTestValid()
        {
            // Arrange
            Banjo banjo = new Banjo
            {
                StringBrand = "John Pearse",
                StringType = "Nickel Wound X-Long",
                StringGauge = "Medium: 10-23"
            };
            string? expected = "John Pearse Nickel Wound X-Long Medium: 10-23";

            // Act
            string? actual = banjo.InstrumentString;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class BanjoPrintTest
    {
        [Test]
        public void BanjoPrintTestValid()
        {
            // Arrange
            Banjo banjo = new Banjo
            {
                Make = "Vega",
                Model = "Long Neck Banjo",
                Type = "open-back acoustic banjo",
                Country = "USA",
                Year = 2020,
                Serial = "1234567",
                Color = "Natural Maple",
                Scale = "long neck",
                StringBrand = "John Pearse",
                StringType = "Nickel Wound X-Long",
                StringGauge = "Medium: 10-23"
            };
            string expected = "Your Vega Long Neck Banjo is an open-back acoustic banjo that was made in USA in 2020. "
                + "It is 2 years old. It is Natural Maple in color. It is a long neck instrument. Its serial number is 1234567. "
                + "It uses John Pearse Nickel Wound X-Long Medium: 10-23 gauge strings.";

            // Act
            string actual = $"Your {banjo.InstrumentName} is an {banjo.Type} that was made in {banjo.Country} in {banjo.Year}. "
            + $"It is {banjo.InstrumentAge} years old. It is {banjo.Color} in color. It is a {banjo.Scale} instrument. Its serial number is {banjo.Serial}. "
            + $"It uses {banjo.InstrumentString} gauge strings.";

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
