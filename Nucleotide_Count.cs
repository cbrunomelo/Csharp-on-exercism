public class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        if (!sequence.All("ACGT".Contains))
            throw new ArgumentException();
        return (sequence + "ACGT").GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count() - 1);
    }
}