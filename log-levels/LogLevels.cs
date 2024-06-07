using System.Text.RegularExpressions;

static class LogLine
{
    private const string RegexString = @"^\[(?<LEVEL>\S*)\]:\s*(?<MESSAGE>.*)\s*$";

    public static string Message(string logLine)
    {

        string message = ExtractLogLineMatch(logLine).Groups["MESSAGE"].Value;
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string level = ExtractLogLineMatch(logLine).Groups["LEVEL"].Value;
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
    /// <returns>Match object with LEVEL & MESSAGE named groups</returns>
    private static Match ExtractLogLineMatch(string logLine)
    {
        Regex regex = new Regex(RegexString, RegexOptions.IgnoreCase);
        return regex.Match(logLine);
    }
}
