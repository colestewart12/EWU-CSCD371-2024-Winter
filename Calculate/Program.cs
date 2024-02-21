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
        Console.WriteLine("Hello, World!");
    }
}
