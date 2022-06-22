using System.Text.RegularExpressions;
public class LogParser
{
    public bool IsValidLine(string txt)
    {

        var rgx = new Regex(@".*[ERR]");

        return rgx.IsMatch(txt);
    }
}