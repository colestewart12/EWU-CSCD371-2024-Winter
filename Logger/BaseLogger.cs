using System;
using System.IO;


namespace Logger;

public abstract class BaseLogger
{

    public string? ClassName { get; set; }
    public abstract void Log(LogLevel logLevel, string message);
}

public class FileLogger : BaseLogger
{
    private readonly string _fileName;

    public FileLogger(string fileName)
    {
        _fileName = fileName;
    }

    public override void Log(LogLevel logLevel, string message)
    {
        string dateTime = DateTime.Now.ToString("M/d/yyyy hh:mm:ss tt");

        string className = nameof(FileLogger);

        string logOutput = $"{dateTime} {className} {logLevel}: {message}";

        File.AppendAllText(_fileName, logOutput);
    }
}
