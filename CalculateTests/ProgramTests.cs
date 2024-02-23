using Calculate;
using IntelliTect.TestTools.Console;

namespace CalculateTests;

public class ProgramTests
{
    [Fact]
    public void WriteLine_TestProperty_Successful()
    {
        // Arrange
        string expectedOutput = "Testing the WriteLine";
        string actualOutput = "";

        // Act & Assert
        Program program = new Program
        {
            // Use the WriteLine property for testing output
            WriteLine = s => actualOutput = s
        };

        program.WriteLine(expectedOutput);

        Assert.Equal(expectedOutput, actualOutput);

    }

    [Fact]
    public void ReadLine_TestProperty_Successful()
    {
        // Arrange
        string expected = "Test ReadLine";

        Program program = new()
        {
            ReadLine = () => expected
        };

        // Act
        string? result = program.ReadLine();

        // Assert
        Assert.Equal(expected, result);
    }
}