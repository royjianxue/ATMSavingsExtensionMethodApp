using System;
using Xunit;
using ATMSavingsExtensionMethods;

namespace XunitTest
{
    public class ProgramTest
    {
        [Fact]
        public void CheckforStringInput()
        {
            //Arrange

            string input = ConsoleHelper.RequestString("what is your name: ");

            //Actual

            //Assert
            Assert.Equal("Roy", input);
        }
    }
}
