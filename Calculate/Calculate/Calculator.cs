using System;
using System.Collections.Generic;

namespace Calculate;

public class Calculator
{
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b) 
    { 
        if (b == 0)
        {
            throw new ArgumentException("Can't divide by 0");
        }

        return a / b;
            
    }
}
