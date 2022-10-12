
public class Isogram
{
    public static bool IsIsogram(string txt)
    {
        var lowerLetters = txt.ToLower().ToList();
        return lowerLetters.Distinct().Count() == lowerLetters.Count;
    }
}