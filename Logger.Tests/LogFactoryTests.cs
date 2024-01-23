using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    //MethodUnderTest_ConditionUnderTest_ExpectedResult
    public void CreateLogger_ValidPathString_LoggerCreatedAndReturned()
    {
        var factory = new LogFactory();
        factory.ConfigureFileLogger("testpath.txt");
        Assert.IsNotNull(factory.CreateLogger());
    }

    [TestMethod]
    public void CreateLogger_NoPathString_NullReturned()
    {
        var factory = new LogFactory();
        Assert.IsNull(factory.CreateLogger());
    }

}

