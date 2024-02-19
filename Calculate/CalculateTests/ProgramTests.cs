using Calculate;
using IntelliTect.TestTools.Console;

namespace CalculateTests;

public class ProgramTests
{
    [Fact]
    public void Test1()
    {
        // Act & Assert
        ConsoleAssert.Expect("Testing the WriteLine",
            () =>
            {
                Program program = new Program();

                program.WriteLine("Testing the WriteLine!");
                var defaultReadResult = program.ReadLine();

                Assert.Null(defaultReadResult);
            });
    }
}