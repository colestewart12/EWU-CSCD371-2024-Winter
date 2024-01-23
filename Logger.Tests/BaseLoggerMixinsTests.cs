using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Logger.Tests;

[TestClass]
public class BaseLoggerMixinsTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Error_WithNullLogger_ThrowsException()
    {
        // Arrange

        // Act
        BaseLoggerMixins.Error(null, "");

        // Assert
    }

    [TestMethod]
    public void Error_WithData_LogsMessage()
    {
        // Arrange
        var logger = new TestLogger();

        // Act
        logger.Error("Message {0}", 42);

        // Assert
        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Error, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("Message 42", logger.LoggedMessages[0].Message);
    }

    [TestMethod]
    public void Warning_WithData_LogsMessage()
    {
        //Arrange
        var logger = new TestLogger();

        //Act
        BaseLoggerMixins.Warning(logger, "hello");

        //Assert
        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Warning, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("hello", logger.LoggedMessages[0].Message);

    }

    [TestMethod]
    public void Warning_NullLogger_ThrowsException()
    {
        // Act and Assert
        Assert.ThrowsException<ArgumentNullException>(() => BaseLoggerMixins.Warning(null, "Test warning message"));
    }

    [TestMethod]
    public void Warning_WithArguments_LogsMessage()
    {
        //Arrange
        var logger = new TestLogger();

        //Act
        BaseLoggerMixins.Warning(logger, "hello", ["arguments"]);

        //Assert
        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Warning, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("hello", logger.LoggedMessages[0].Message);
    }

    [TestMethod]
    public void Information_WithData_LogsMessage()
    {
        //Arrange
        var logger = new TestLogger();

        //Act
        BaseLoggerMixins.Information(logger, "hello", []);

        //Assert
        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Information, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("hello", logger.LoggedMessages[0].Message);

    }

    [TestMethod]
    public void Information_NullLogger_ThrowsException()
    {
        // Act and Assert
        Assert.ThrowsException<ArgumentNullException>(() => BaseLoggerMixins.Information(null, "Test warning message"));
    }

    [TestMethod]
    public void Information_WithArguments_LogsMessage()
    {
        //Arrange
        var logger = new TestLogger();

        //Act
        BaseLoggerMixins.Information(logger, "hello", ["arguments"]);

        //Assert
        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Information, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("hello", logger.LoggedMessages[0].Message);
    }

    [TestMethod]
    public void Debug_WithData_LogsMessage()
    {
        //Arrange
        var logger = new TestLogger();

        //Act
        BaseLoggerMixins.Debug(logger, "hello");

        //Assert
        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Debug, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("hello", logger.LoggedMessages[0].Message);

    }

    [TestMethod]
    public void Debug_NullLogger_ThrowsException()
    {
        // Act and Assert
        Assert.ThrowsException<ArgumentNullException>(() => BaseLoggerMixins.Debug(null, "Test warning message"));
    }

    [TestMethod]
    public void Debug_WithArguments_LogsMessage()
    {
        //Arrange
        var logger = new TestLogger();


        //Act
        BaseLoggerMixins.Debug(logger, "hello", ["arguments"]);


        //Assert
        Assert.AreEqual(1, logger.LoggedMessages.Count);
        Assert.AreEqual(LogLevel.Debug, logger.LoggedMessages[0].LogLevel);
        Assert.AreEqual("hello", logger.LoggedMessages[0].Message);
    }
}

public class TestLogger : BaseLogger
{
    public List<(LogLevel LogLevel, string Message)> LoggedMessages { get; } = new List<(LogLevel, string)>();

    public override void Log(LogLevel logLevel, string message)
    {
        LoggedMessages.Add((logLevel, message));
    }
}
