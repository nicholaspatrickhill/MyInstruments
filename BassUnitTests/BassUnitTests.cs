using MyInstruments2;

namespace BassUnitTests
{
    public class BassNameTest
    {
        [Test]
        public void BassNameTestValid()
        {
            //--Arrange
            Bass bass = new Bass
            {
                Make = "Guild",
                Model = "Starfire"
            };
            string expected = "Guild Starfire";

            //--Act
            string actual = bass.InstrumentName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
    public class BassAgeTest
    {
        [Test]
        public void BassAgeTestValid()
        {
            //--Arrange
            Bass bass = new Bass
            {
                Year = 2000
            };
            int expected = 22;

            //--Act
            int actual = bass.InstrumentAge;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
    public class BassStringTest
    {
        [Test]
        public void BassStringTestValid()
        {
            //--Arrange
            Bass bass = new Bass
            {
                StringBrand = "Ernie Ball",
                StringType = "Regular Slinky Bass",
                StringGauge = "45-105"

            };
            string expected = "Ernie Ball Regular Slinky Bass 45-105";

            //--Act
            string actual = bass.InstrumentString;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}