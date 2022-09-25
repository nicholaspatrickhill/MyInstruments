using MyInstruments2;

namespace MyInstrumentNameCheck
{
    public class InstrumentNameTest
    {
        [Test]
        public void InstrumentNameTestValid()
        {
            //--Arrange
            MusicalInstrument musicalInstrument = new MusicalInstrument
            {
                Make = "Fender",
                Model = "Starcaster"
            };
            string expected = "Fender Starcaster";

            //--Act
            string actual = musicalInstrument.InstrumentName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
}