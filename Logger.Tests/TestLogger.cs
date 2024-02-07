namespace Logger.Tests;

public class TestLogger(string logSource) : BaseLogger(logSource), ILogger
{
    public List<(LogLevel LogLevel, string Message)> LoggedMessages { get; } = new List<(LogLevel, string)>();

    public static ILogger CreateLogger(in TestLoggerConfiguration configuration) => 
        new TestLogger(configuration.LogSource);

    static ILogger ILogger.CreateLogger(in ILoggerConfiguration configuration) => 
        configuration is TestLoggerConfiguration testLoggerConfiguration
            ? CreateLogger(testLoggerConfiguration)
            : throw new ArgumentException("Invalid configuration type", nameof(configuration));

    public override void Log(LogLevel logLevel, string message) => LoggedMessages.Add((logLevel, message));
}

public class TestLoggerConfiguration(string logSource) : BaseLoggerConfiguration(logSource), ILoggerConfiguration
{
}
