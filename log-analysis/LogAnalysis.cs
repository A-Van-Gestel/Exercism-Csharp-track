using System;

public static class LogAnalysis
{
    // DONE: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string substring)
    {
        int indexLastCharSubstring = str.IndexOf(substring, StringComparison.Ordinal) + substring.Length;

        return str.Substring(indexLastCharSubstring);
    }

    // DONE: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string leftSeparator, string rightSeparator)
    {
        int indexLastCharLeftSeparator = str.IndexOf(leftSeparator, StringComparison.Ordinal) + leftSeparator.Length;
        int indexFirstCharRightSeparator = str.IndexOf(rightSeparator, StringComparison.Ordinal);

        int substringLength = indexFirstCharRightSeparator - indexLastCharLeftSeparator;

        return str.Substring(indexLastCharLeftSeparator, substringLength);
    }

    // DONE: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // DONE: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}