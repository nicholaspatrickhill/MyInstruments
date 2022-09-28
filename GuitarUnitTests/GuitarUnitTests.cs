using MyInstruments2;
using NUnit.Framework.Constraints;

namespace GuitarUnitTests
{
    public class GuitarNameTest
    {
        [Test]
        public void GuitarNameTestValid()
        {
            //--Arrange
            Guitar guitar = new Guitar
            {
                Make = "Fender",
                Model = "Starcaster"
            };
            string expected = "Fender Starcaster";

            //--Act
            string actual = guitar.InstrumentName;

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
                Year = 2000
            };
            int expected = 22;

            //--Act
            int actual = guitar.InstrumentAge;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
    public class InstrumentStringTest
    {
        [Test]
        public void GuitarStringTestValid()
        {
            //--Arrange
            Guitar guitar = new Guitar
            {
                StringBrand = "Ernie Ball",
                StringType = "Regular Slinky",
                StringGauge = "10-46"

            };
            string expected = "Ernie Ball Regular Slinky 10-46";

            //--Act
            string actual = guitar.InstrumentString;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}






