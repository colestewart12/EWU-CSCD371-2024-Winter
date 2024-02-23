namespace Calculate;
using System;

public class Program
{
    //Action is for referring to void-returning methods
    public Action<string> WriteLine { get; init; } = Console.WriteLine;
    //Func is for referring to methods that return a value
    public Func<string?> ReadLine { get; init; } = Console.ReadLine;

    public Program()
    {
    }
    static void Main(string[] args)
    {
        Program program = new();

        while (true)
        {
            program.WriteLine("Enter an equation:");
            string? equation = program.ReadLine();

            if (string.IsNullOrEmpty(equation))
            {
                program.WriteLine("Invalid. Please enter a valid equation.");
                continue;
            }

            if (Calculator.TryCalculate(equation, out double solution))
            {
                program.WriteLine($"Result: {solution}");
            }
            else
            {
                program.WriteLine("Invalid. Please enter a valid equation.");
            }

            program.WriteLine("Do you want to ask another? (Y/N)");
            string? response = program.ReadLine();

            if (string.Equals(response, "N", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }
}
