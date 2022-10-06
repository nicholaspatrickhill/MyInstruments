using MyInstruments;
using NUnit.Framework.Constraints;

namespace GuitarUnitTests
{
    // Fulfills Feature List Requirement: "Create 3 or more unit tests for your application"
    public class GuitarNameTest
    {
        [Test]
        public void GuitarNameTestValid()
        {
            //--Arrange
            Guitar guitar = new Guitar
            {
                make = "Fender",
                model = "Starcaster"
            };
            string expected = "Fender Starcaster";

            //--Act
            string actual = guitar.instrumentName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
   public class GuitarAgeTest
    {
        [Test]
        public void GuitarAgeTestValid()
        {
            //--Arrange
            Guitar guitar = new Guitar
            {
                year = 2000
            };
            int expected = 22;

            //--Act
            int actual = guitar.instrumentAge;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
    public class GuitarStringTest
    {
        [Test]
        public void GuitarStringTestValid()
        {
            //--Arrange
            Guitar guitar = new Guitar
            {
                stringBrand = "Ernie Ball",
                stringType = "Regular Slinky",
                stringGauge = "10-46"

            };
            string expected = "Ernie Ball Regular Slinky 10-46";

            //--Act
            string actual = guitar.instrumentString;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}






