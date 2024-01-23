using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    //MethodUnderTest_ConditionUnderTest_ExpectedResult
    public void Log_OutputEntryToLog_SuccesfulOutput()
    {
        string filePath = "testFile.txt";
        string message = "Hello from file";

        var filelog = new FileLogger(filePath);

        filelog.Log(LogLevel.Warning, message);

        Assert.IsTrue(File.ReadAllText(filePath).Contains($" FileLogger Warning: {message}"));
        File.Delete(filePath);

    }

}
