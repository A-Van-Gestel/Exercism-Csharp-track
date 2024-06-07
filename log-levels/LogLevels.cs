using System.Text.RegularExpressions;

static class LogLine
{
    private const string RegexString = @"^\[(?<LEVEL>\S*)\]:\s*(?<MESSAGE>.*)\s*$";

    public static string Message(string logLine)
    {

        string message = ExtractLogLine(logLine).Groups["MESSAGE"].Value;
        return RemoveWhitespaceCharacters(message);
    }

    public static string LogLevel(string logLine)
    {
        string level = ExtractLogLine(logLine).Groups["LEVEL"].Value;
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
    private static Match ExtractLogLine(string logLine)
    {
        Regex regex = new Regex(RegexString, RegexOptions.IgnoreCase);
        return regex.Match(logLine);
    }

    /// <summary>
    /// Remove trailing whitespace characters from message
    /// </summary>
    /// <returns>Match object with LEVEL & MESSAGE named groups</returns>
    private static string RemoveWhitespaceCharacters(string message)
    {
        message = message.Replace(@"\t", "");
        message = message.Replace(@"\r", "");
        message = message.Replace(@"\n", "");
        return message.Trim();
    }
}
