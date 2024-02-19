

using Calculate;

namespace CalculateTests;

public class CalculatorTests
{
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(2,-3,-1)]
    public void Add_TwoDoubles_SuccessfulAdd(double a, double b, double result)
    {
        // Act
        double number = Calculator.Add(a, b);

        //Assert
        Assert.Equal(result, number);

    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(2, 3, -1)]
    public void Subtract_TwoDoubles_SuccessfulAdd(double a, double b, double result)
    {
        // Act
        double number = Calculator.Subtract(a, b);

        //Assert
        Assert.Equal(result, number);

    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, -3, -6)]
    public void Multiply_TwoDoubles_SuccessfulAdd(double a, double b, double result)
    {
        // Act
        double number = Calculator.Multiply(a, b);

        //Assert
        Assert.Equal(result, number);

    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(2, -2, -1)]
    public void Divide_TwoDoubles_SuccessfulAdd(double a, double b, double result)
    {
        // Act
        double number = Calculator.Divide(a, b);

        //Assert
        Assert.Equal(result, number);

    }
}
