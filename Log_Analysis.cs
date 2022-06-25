
public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string subString)
        => str.Substring(str.IndexOf(subString) + subString.Length);
    public static string SubstringBetween(this string str, string firstDelimiter, string secondDelimiter)
        => str.Substring(str.IndexOf(firstDelimiter) + firstDelimiter.Length, str.IndexOf(secondDelimiter) - str.IndexOf(firstDelimiter) - firstDelimiter.Length);
    public static string Message(this string str)
        => str.SubstringAfter(": ");
    public static string LogLevel(this string str)
        => str.SubstringBetween("[", "]");
}