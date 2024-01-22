namespace Logger;

public class LogFactory
{

    private string? fileLoggerPath;

    public void ConfigureFileLogger(string filePath)
    {
        fileLoggerPath = filePath;
    }

    public BaseLogger? CreateLogger()
    {
        if (fileLoggerPath != null)
        {
            BaseLogger baseLogger = new FileLogger(fileLoggerPath)
            {
                ClassName = nameof(LogFactory)
            };
            return baseLogger;
        }

        return null;
    }
}
