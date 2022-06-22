public static class AssemblyLine
{
    public static string SuccessRate(int i) => i switch
    {
        0 => "0% success rate.",
        >= 1 and <= 4 => "100% success rate.",
        >= 5 and <= 8 => "90% success rate.",
        9 => "80% success rate.",
        10 => "77% success rate.",
        _ => "Valor fora da range",

    };
}