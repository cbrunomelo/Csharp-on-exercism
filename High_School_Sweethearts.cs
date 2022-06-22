public static class heart
{
    public static void DrawHeart()
    {
        char o = '*';
        Console.WriteLine("  " + o + o + o + "   " + o + o + o);
        Console.WriteLine(" " + o + "   " + o + " " + o + "   " + o);
        Console.WriteLine(o + "     " + o + "     " + o);
        Console.WriteLine(o + "     " + " " + "     " + o);
        Console.WriteLine(o + "     " + " " + "     " + o);
        Console.WriteLine(" " + o + "    " + "     " + o);
        Console.WriteLine("  " + o + "   " + "    " + o);
        Console.WriteLine("   " + o + "  " + "   " + o);
        Console.WriteLine("    " + o + "  " + " " + o);
        Console.WriteLine("     " + o + " " + o);
        Console.WriteLine("      " + o);
    }
}

public static class HighSchoolSweethearts
{
    public static void DisplaySingleLine(string a, string b)
    {
        Console.WriteLine($"{a} {b}");
        heart.DrawHeart();

    }
}