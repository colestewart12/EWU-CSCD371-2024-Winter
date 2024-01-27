using Xunit;
using System;
using System.IO;

namespace CanHazFunny.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void WriteJoke_WritesToConsole_SuccessfulReturn()
        {
            //Arrange
            var consoleOutput = new StringWriter();

            //Redirect Console to StringWriter
            Console.SetOut(consoleOutput);
            var testOutput = new JokeOutput();
            string joke = "Test joke!";

            //Act
            testOutput.WriteJoke(joke);

            //Assert
            string consoleText = consoleOutput.ToString().Trim();
            Assert.Equal(joke, consoleText);

        }
    }
}
