

using Calculate;

namespace CalculateTests;

public class CalculatorTests
{
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(2,-3,-1)]
    public void Add_TwoDoubles_SuccessfulAdd(int a, int b, double result)
    {
        // Act
        double number = Calculator.Add(a, b);

        //Assert
        Assert.Equal(result, number);

    }

    [Theory]
    [InlineData('+', 1,2,3)]
    [InlineData('-', 2,3,-1)]
    [InlineData('*', 2,3,6)]
    [InlineData('/', 6,3,2)]
    public void MathematicalOperations_UsingGenericDictionary_SuccessfulAdd(char operationSymbol, int a, int b, double result)
    {
        //Arrange
        var operation = Calculator.MathematicalOperations[operationSymbol];

        //Act
        double number = operation(a, b);

        //Assert
        Assert.Equal(result, number);
    }

    [Theory]
    [InlineData("1 + 2", 3)]
    [InlineData("2 - 3", -1)]
    [InlineData("2 * 3", 6)]
    [InlineData("6 / 3", 2)]
    public void TryCalculate_ValidInputs_SuccessfulOperation(string input, double result)
    {
        //Act
        bool canCalculate = Calculator.TryCalculate(input, out double output);

        //Assert
        Assert.True(canCalculate);
        Assert.Equal(result, output);
    }

    [Theory]
    [InlineData("1 2")]
    [InlineData("1 2 3")]
    [InlineData("1 + 2 3")]
    [InlineData("a * 3")]
    [InlineData("1 ++ 2")]
    public void TryCalculate_InvalidInputs_UnsuccessfulOperation(string input)
    {
        //Act
        bool canCalculate = Calculator.TryCalculate(input, out double output);

        //Assert
        Assert.False(canCalculate);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(2, 3, -1)]
    public void Subtract_TwoDoubles_SuccessfulAdd(int a, int b, double result)
    {
        // Act
        double number = Calculator.Subtract(a, b);

        //Assert
        Assert.Equal(result, number);

    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, -3, -6)]
    public void Multiply_TwoDoubles_SuccessfulAdd(int a, int b, double result)
    {
        // Act
        double number = Calculator.Multiply(a, b);

        //Assert
        Assert.Equal(result, number);

    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(2, -2, -1)]
    public void Divide_TwoDoubles_SuccessfulAdd(int a, int b, double result)
    {
        // Act
        double number = Calculator.Divide(a, b);

        //Assert
        Assert.Equal(result, number);

    }
    
    [Fact]
    public void Divide_ByZeroThrowsArgumentException()
    {
        // Arrange
        int a = 5;
        int b = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Calculator.Divide(a, b));
    }
}
