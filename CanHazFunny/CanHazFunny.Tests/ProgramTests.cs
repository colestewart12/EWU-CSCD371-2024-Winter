using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
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
            Assert.AreEqual(joke, consoleText);

        }
    }
}
