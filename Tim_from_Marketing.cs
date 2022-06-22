static class Badge
{
    public static string Print(int? a, string name, string? departament)
    {
        Console.WriteLine(a.HasValue); //false
        return $"{a} - {name} - {departament?.ToUpper() ?? "Owner"}";
    }

}