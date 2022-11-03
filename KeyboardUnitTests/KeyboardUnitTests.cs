using MyInstruments;
using System.Reflection;
using System.Xml.Schema;

namespace KeyboardUnitTests
{
    // Fulfills Feature List Requirement: "Create 3 or more unit tests for your application"

    public class KeyboardNameTest
    {
        [Test]
        public void KeyboardNameTestValid()
        {
            // Arrange
            KeyboardInstrument keyboardInstrument = new KeyboardInstrument
            {
                
                Make = "Moog",
                Model = "Grandmother"

            };
            string? expected = "Moog Grandmother";

            // Act
            string? actual = keyboardInstrument.InstrumentName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
    public class KeyboardAgeTest
    {
        [Test]
        public void KeyboardAgeTestValid()
        {
            // Arrange
            KeyboardInstrument keyboardInstrument = new KeyboardInstrument
            {
                Year = 2000
            };
            int expected = 22;

            // Act
            int actual = keyboardInstrument.InstrumentAge;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
 

    public class BanjoPrintTest
    {
        [Test]
        public void BanjoPrintTestValid()
        {
            // Arrange
            KeyboardInstrument keyboardInstrument = new KeyboardInstrument
            {
                Make = "Moog",
                Model = "Grandmother",
                Type = "analog synthesizer",
                Country = "USA",
                Year = 2020,
                Serial = "1234567",
                Color = "black",
                NumberOfKeys = "32",
                KeyWeight = "non-weighted",
            };
            string expected = "Your Moog Grandmother is an analog synthesizer that was made in USA in 2020. "
                + "It is 2 years old. It is black in color. It has 32 non-weighted keys. Its serial number is 1234567. ";

            // Act
            string actual = $"Your {keyboardInstrument.InstrumentName} is an {keyboardInstrument.Type} that was made in {keyboardInstrument.Country} in {keyboardInstrument.Year}. "
            + $"It is {keyboardInstrument.InstrumentAge} years old. It is {keyboardInstrument.Color} in color. It has {keyboardInstrument.NumberOfKeys} {keyboardInstrument.KeyWeight} keys. Its serial number is {keyboardInstrument.Serial}. ";

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

