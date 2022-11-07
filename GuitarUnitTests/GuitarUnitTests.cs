using MyInstruments;
using NUnit.Framework.Constraints;

namespace GuitarUnitTests
{
    public class GuitarListOfKeysTest
    {
        [Test]
        public void GuitarListOfKeysTestValid()
        {
            // Arrange
            Dictionary<string, Guitar> testGuitars = new Dictionary<string, Guitar>()
                    {
                        { "Fender Starcaster", new Guitar() },
                        { "Jackson Dinky", new Guitar() },
                    };

            List<string> testGuitarsKeyList = new List<string>(testGuitars.Keys);

            List<string> expected = testGuitarsKeyList;

            // Act
            List<string> actual;
            actual = new List<string>(testGuitars.Keys);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class GuitarNameTest
    {
        [Test]
        public void GuitarNameTestValid()
        {
            // Arrange
            Guitar guitar = new Guitar
            {
                Make = "Fender",
                Model = "Starcaster"
            };
            string expected = "Fender Starcaster";

            // Act
            string actual = guitar.InstrumentName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
   public class GuitarAgeTest
    {
        [Test]
        public void GuitarAgeTestValid()
        {
            // Arrange
            Guitar guitar = new Guitar
            {
                Year = 2000
            };
            int expected = 22;

            // Act
            int actual = guitar.InstrumentAge;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
    public class GuitarStringTest
    {
        [Test]
        public void GuitarStringTestValid()
        {
            // Arrange
            Guitar guitar = new Guitar
            {
                StringBrand = "Ernie Ball",
                StringType = "Regular Slinky",
                StringGauge = "10-46"

            };
            string expected = "Ernie Ball Regular Slinky 10-46";

            // Act
            string actual = guitar.InstrumentString;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        public class GuitarPrintTest
        {
            [Test]
            public void GuitarPrintTestValid()
            {
                // Arrange
                Guitar guitar = new Guitar
                {
                    Make = "Fender",
                    Model = "Starcaster",
                    Type = "hollow-body electric guitar",
                    Country = "USA",
                    Year = 2020,
                    Serial = "1234567",
                    Color = "sunburst",
                    StringBrand = "Ernie Ball",
                    StringType = "Regular Slinky",
                    StringGauge = "10-46"
                };
                string expected = "Your Fender Starcaster is a hollow-body electric guitar that was made in USA in 2020. "
                    + "It is 2 years old. It is sunburst in color. Its serial number is 1234567. "
                    + "It uses Ernie Ball Regular Slinky 10-46 gauge strings.";

                // Act
                string actual = $"Your {guitar.InstrumentName} is a {guitar.Type} that was made in {guitar.Country} in {guitar.Year}. "
                + $"It is {guitar.InstrumentAge} years old. It is {guitar.Color} in color. Its serial number is {guitar.Serial}. "
                + $"It uses {guitar.InstrumentString} gauge strings.";

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}






