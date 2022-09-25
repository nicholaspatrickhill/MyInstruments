using MyInstruments2;

namespace InstrumentStringUnitTest
{
    public class InstrumentStringTest
    {
        [Test]
        public void InstrumentStringTestValid()
        {
                //--Arrange
            MusicalInstrument musicalInstrument = new MusicalInstrument
            {
                    StringBrand = "Ernie Ball",
                    StringType = "Regular Slinky",
                    StringGauge = "10"
                    
            };
            string expected = "Ernie Ball Regular Slinky 10";

            //--Act
            string actual = musicalInstrument.InstrumentString;

            //--Assert
                Assert.AreEqual(expected, actual);
            }
    }
}