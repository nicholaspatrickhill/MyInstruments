using MyInstruments2;

namespace MusicalInstrumentAgeCheck
{
    public class InstrumentAgeTest
    {
        [Test]
        public void InstrumentAgeTestValid()
        {
            //--Arrange
            MusicalInstrument musicalInstrument = new MusicalInstrument
            {
                Year = 2000
            };
            int expected = 22;

            //--Act
            int actual = musicalInstrument.Age;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}