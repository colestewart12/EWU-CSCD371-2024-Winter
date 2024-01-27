using Xunit;
using Moq;
using System;

namespace CanHazFunny.Tests;


public class JesterTests
{
        [Fact]
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
            Assert.Equal("Normal joke", mockJokeOutput.Invocations[0].Arguments[0] as string);

        }

        [Fact]
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
            Assert.Equal("Normal joke", mockJokeOutput.Invocations[0].Arguments[0] as string);
        }

        [Fact]
        public void TellJoke_NullJokeOutput_ThrowsException()
        {
            //Arrange
            IJokeOutput? nullJokeOutput = null;
            var mockJokeService = new Mock<IJokeService>();

            Assert.Throws<ArgumentNullException>(() => new Jester(nullJokeOutput!, mockJokeService.Object));
        }

        [Fact]
        public void TellJoke_NullJokeService_ThrowsException()
        {
            //Arrange
            IJokeService? nullJokeService = null;
            var mockJokeOutput = new Mock<IJokeOutput>();

            var jester = new Jester(mockJokeOutput.Object, nullJokeService!);
            Assert.Throws<ArgumentNullException>(() => new Jester(mockJokeOutput.Object, nullJokeService!));
        }
}
