public class Hamming
{
    public static int HammingDistance(string a, string b)
    {
        int Count = 0;
        if (a.Length == b.Length)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    Count++;
            }
        }

        return Count;
    }
}