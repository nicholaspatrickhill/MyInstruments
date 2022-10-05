using MyInstruments2;

namespace BassUnitTests
{
    // Fulfills Feature List Requirement: "Create 3 or more unit tests for your application"
    public class BassNameTest
    {
        [Test]
        public void BassNameTestValid()
        {
            //--Arrange
            Bass bass = new Bass
            {
                make = "Guild",
                model = "Starfire"
            };
            string expected = "Guild Starfire";

            //--Act
            string actual = bass.instrumentName;

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
                year = 2000
            };
            int expected = 22;

            //--Act
            int actual = bass.instrumentAge;

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
                stringBrand = "Ernie Ball",
                stringType = "Regular Slinky Bass",
                stringGauge = "45-105"

            };
            string expected = "Ernie Ball Regular Slinky Bass 45-105";

            //--Act
            string actual = bass.instrumentString;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}