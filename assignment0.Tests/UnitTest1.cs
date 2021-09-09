using System;
using Xunit;

namespace assignment0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeap_InputIsNot4_ReturnFalse()
        {

            var expected = false;
            var actual = leapyear.IsLeapYear(2333);
            //Arrange
            //var writer = new StringWriter();
            //Console.SetOut(writer);

            //Act
            //Program.Main(new string[0]);

            //Assert
            //var output = writer.GetStringBuilder().ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLeap_InputIs4_ReturnTrue()
        {

            var expected = true;
            var actual = leapyear.IsLeapYear(4);
            //Arrange
            //var writer = new StringWriter();
            //Console.SetOut(writer);

            //Act
            //Program.Main(new string[0]);

            //Assert
            //var output = writer.GetStringBuilder().ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLeap_InputIsDivisable4_ReturnTrue()
        {

            var expected = false;
            var actual = leapyear.IsLeapYear(2333);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLeap_InputIsDivisable4and100_ReturnFalse()
        {

            var expected = false;
            var actual = leapyear.IsLeapYear(500);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLeap_InputIsDivisable4andNot100_ReturnTrue()
        {

            var expected = true;
            var actual = leapyear.IsLeapYear(40);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLeap_InputIsDivisable4andNot100and400_ReturnTrue()
        {

            var expected = true;
            var actual = leapyear.IsLeapYear(1600);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void IsLeap_InputIsDivisable4and100not400_ReturnFalse()
        {

            var expected = false;
            var actual = leapyear.IsLeapYear(1700);
            Assert.Equal(expected, actual);
        }

    }
}
