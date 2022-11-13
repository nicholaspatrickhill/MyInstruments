using MyInstruments;
using NUnit.Framework.Constraints;

namespace MusicalInstrumentUnitTests
{
    public class TestDictionary
    {
        public Dictionary<string, Guitar> testGuitars = new Dictionary<string, Guitar>()
                    {
                        { "Fender Starcaster", new Guitar() },
                        { "Jackson Dinky", new Guitar() },
                        { "PRS SE24", new Guitar() },
                        { "Gibson SG", new Guitar() },
                        { "Parker Fly", new Guitar() },
                    };
    }

    public class ArrayOfKeysTest : TestDictionary
    {
        [Test]
        public void ArrayOfKeysTestValid()
        {
            // Arrange
            string[] testGuitarKeysArray = testGuitars.Keys.ToArray();

            string[] expected = testGuitarKeysArray;

            // Act
            string[] actual;
            actual = testGuitars.Keys.ToArray();

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class InstrumentCountTest : TestDictionary
    {
        [Test]
        public void InstrumentCountTestValid()
        {
            // Arrange
            int testGuitarsCount = testGuitars.Count;

            int expected = 5;

            // Act
            int actual = testGuitarsCount;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class InstrumentPercentageTest : TestDictionary
    {
        [Test]
        public void InstrumentPercentageTestValid()
        {
            // Arrange
            int testGuitarsCount = testGuitars.Count;
            int totalCount = 10;
            int testGuitarsPercentage = (int)Math.Round(((double)testGuitarsCount / (double)totalCount) * 100);

            int expected = 50;

            // Act
            int actual = testGuitarsPercentage;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class InstrumentNameTest
    {
        [Test]
        public void InstrumentNameTestValid()
        {
            // Arrange
            Guitar guitar = new Guitar
            {
                Make = "Fender",
                Model = "Starcaster"
            };
            string expected = "Fender Starcaster";

            // Act
            string? actual = guitar.InstrumentName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
   public class InstrumentAgeTest
    {
        [Test]
        public void InstrumentAgeTestValid()
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
    public class InstrumentStringTest
    {
        [Test]
        public void InstrumentStringTestValid()
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
            string? actual = guitar.InstrumentString;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        public class PrintInstrumentTest
        {
            [Test]
            public void PrintInstrumentTestValid()
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






