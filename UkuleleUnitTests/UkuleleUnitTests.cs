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
                make = "Martin",
                model = "T1K"
            };
            string expected = "Martin T1K";

            //--Act
            string actual = ukulele.instrumentName;

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
                year = 2000
            };
            int expected = 22;

            //--Act
            int actual = ukulele.instrumentAge;

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
                stringBrand = "Martin",
                stringType = "Tenor Fluorocarbon",
                stringGauge = "22"

            };
            string expected = "Martin Tenor Fluorocarbon 22";

            //--Act
            string actual = ukulele.instrumentString;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}