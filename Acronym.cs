using System.Text;

public class Acronym
{
    public static string ToAcronym(string txt)
    {   
        string result = "";
        var substrings = txt.Split(' ');
        var FirstChars = substrings.Select(x => x[0]);
        foreach(var letter in FirstChars)
            result += letter.ToString().ToUpper();
        return result;            
    }
}