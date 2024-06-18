using System.Text.RegularExpressions;

static class LogLine
{
    private const string RegexString = @"^\[(?<LEVEL>\S*)\]:\s*(?<MESSAGE>.*)\s*$";

    public static string Message(string logLine)
    {

        string message = ExtractLogLine(logLine).message;
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string level = ExtractLogLine(logLine).level;
        return level.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        return $"{message} ({level})";
    }

    /// <summary>
    /// Extract LEVEL & MESSAGE from log line
    /// </summary>
    /// <returns>Tuple with level & message properties</returns>
    private static (string level, string message) ExtractLogLine(string logLine)
    {
        Regex regex = new Regex(RegexString, RegexOptions.IgnoreCase);
        Match match = regex.Match(logLine);
        return (match.Groups["LEVEL"].Value, match.Groups["MESSAGE"].Value);
    }
}
