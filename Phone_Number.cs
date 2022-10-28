using System.Text.RegularExpressions;

public class Phone_Number
{
    public static string Clean(string phoneNumber)
    {
        var match = Regex.Match(string.Concat(phoneNumber.Where(char.IsDigit)), @"^1?([2-9]\d\d[2-9]\d{6})$");
        return match.Success ? match.Groups[1].ToString() : throw new ArgumentException();
    }
}