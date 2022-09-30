using MyInstruments2;

namespace UkuleleUnitTests
{
    public class UkuleleNameTest
    {
        [Test]
        public void UkuleleNameTestValid()
        {
            //--Arrange
            Ukulele ukulele = new Ukulele
            {
                Make = "Martin",
                Model = "T1K"
            };
            string expected = "Martin T1K";

            //--Act
            string actual = ukulele.InstrumentName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
    public class UkuleleAgeTest
    {
        [Test]
        public void UkuleleAgeTestValid()
        {
            //--Arrange
            Ukulele ukulele = new Ukulele
            {
                Year = 2000
            };
            int expected = 22;

            //--Act
            int actual = ukulele.InstrumentAge;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
    public class UkuleleStringTest
    {
        [Test]
        public void UkuleleStringTestValid()
        {
            //--Arrange
            Ukulele ukulele = new Ukulele
            {
                StringBrand = "Martin",
                StringType = "Tenor Fluorocarbon",
                StringGauge = "22"

            };
            string expected = "Martin Tenor Fluorocarbon 22";

            //--Act
            string actual = ukulele.InstrumentString;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}