using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [TestMethod]
        public void TellJoke_NormalData_SuccessfulReturn()
        {
            //Arrange
            var mockJokeOutput = new Mock<IJokeOutput>();
            var mockJokeService = new Mock<IJokeService>();

            mockJokeService.SetupSequence(x => x.GetJoke()).Returns("Normal joke");

            var jester = new Jester(mockJokeOutput.Object, mockJokeService.Object);

            //Act
            jester.TellJoke();

            //Assert
            Assert.AreEqual("Normal joke", mockJokeOutput.Invocations[0].Arguments[0] as string);

        }

        [TestMethod]
        public void TellJoke_ChuckNorrisFirstNormalSecond_SuccessfulReturn()
        {
            //Arrange
            var mockJokeOutput = new Mock<IJokeOutput>();
            var mockJokeService = new Mock<IJokeService>();

            mockJokeService.SetupSequence(x => x.GetJoke())
                .Returns("Chuck Norris joke")
                .Returns("Normal joke");
            var jester = new Jester(mockJokeOutput.Object, mockJokeService.Object);

            //Act
            jester.TellJoke();

            //Assert
            Assert.AreEqual("Normal joke", mockJokeOutput.Invocations[0].Arguments[0] as string);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TellJoke_NullJokeOutput_ThrowsException()
        {
            //Arrange
            IJokeOutput? nullJokeOutput = null;
            var mockJokeService = new Mock<IJokeService>();

            var jester = new Jester(nullJokeOutput!, mockJokeService.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TellJoke_NullJokeService_ThrowsException()
        {
            //Arrange
            IJokeService? nullJokeService = null;
            var mockJokeOutput = new Mock<IJokeOutput>();

            var jester = new Jester(mockJokeOutput.Object, nullJokeService!);
        }
    }
}
