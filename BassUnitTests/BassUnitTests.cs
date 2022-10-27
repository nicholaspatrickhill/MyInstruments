using MyInstruments;

namespace BassUnitTests
{
    // Fulfills Feature List Requirement: "Create 3 or more unit tests for your application"
    public class BassNameTest
    {
        [Test]
        public void BassNameTestValid()
        {
            // Arrange
            Guitar bass = new Guitar
            {
                Make = "Guild",
                Model = "Starfire"
            };
            string expected = "Guild Starfire";

            // Act
            string actual = bass.InstrumentName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
    public class BassAgeTest
    {
        [Test]
        public void BassAgeTestValid()
        {
            // Arrange
            Guitar bass = new Guitar
            {
                Year = 2000
            };
            int expected = 22;

            // Act
            int actual = bass.InstrumentAge;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
    public class BassStringTest
    {
        [Test]
        public void BassStringTestValid()
        {
            // Arrange
            Guitar bass = new Guitar
            {
                StringBrand = "Ernie Ball",
                StringType = "Regular Slinky Bass",
                StringGauge = "45-105"

            };
            string expected = "Ernie Ball Regular Slinky Bass 45-105";

            // Act
            string actual = bass.InstrumentString;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        public class BassPrintTest
        {
            [Test]
            public void BassPrintTestValid()
            {
                // Arrange
                Bass bass = new Bass
                {
                    Make = "Guild",
                    Model = "Starfire",
                    Type = "hollow-body electric bass",
                    Country = "USA",
                    Year = 2020,
                    Serial = "1234567",
                    Color = "red",
                    Scale = "short",
                    StringBrand = "Ernie Ball",
                    StringType = "Regular Slinky Bass",
                    StringGauge = "45-105"
                };
                string expected = "Your Guild Starfire is a hollow-body electric bass that was made in USA in 2020. "
                    + "It is 2 years old. It is red in color. It is a short scale instrument. Its serial number is 1234567. "
                    + "It uses Ernie Ball Regular Slinky Bass 45-105 gauge strings.";

                // Act
                string actual = $"Your {bass.InstrumentName} is a {bass.Type} that was made in {bass.Country} in {bass.Year}. "
                + $"It is {bass.InstrumentAge} years old. It is {bass.Color} in color. It is a {bass.Scale} scale instrument. Its serial number is {bass.Serial}. "
                + $"It uses {bass.InstrumentString} gauge strings.";

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}