using System;
using System.Collections.Generic;

namespace Calculate;

public class Calculator
{
    public static double Add(int a, int b) => a + b;
    public static double Subtract(int a, int b) => a - b;
    public static double Multiply(int a, int b) => a * b;
    public static double Divide(int a, int b) 
    { 
        if (b == 0)
        {
            throw new ArgumentException("Can't divide by 0");
        }

        return a / b;
            
    }

    public static IReadOnlyDictionary<char, Func<int, int, double>> MathematicalOperations { get; }
        = new Dictionary<char, Func<int, int, double>>
        {
            {'+', Add },
            {'-', Subtract },
            {'*', Multiply },
            {'/', Divide },
        };

    public static bool TryCalculate(string input, out double output)
    {
        string[] items = input.Split();
        if (items.Length != 3 )
        {
            output = 0;
            return false;
        }
        int first;
        bool firstValid = int.TryParse(items[0], out first);
        int second;
        bool secondValid = int.TryParse(items[2], out second);
        if (!(firstValid && secondValid))
        {
            output = 0;
            return false;
        }
        if(items[1].Length > 1)
        {
            output = 0;
            return false;
        }
        char operationChar = items[1].ToCharArray()[0];
        if(operationChar != '+' && operationChar != '-' && operationChar != '*' && operationChar != '/')
        {
            output = 0;
            return false;
        }
        output = MathematicalOperations[operationChar](first, second);

        return true;
    }
}
