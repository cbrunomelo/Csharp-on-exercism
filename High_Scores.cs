public class HightScores
{


    public static void Pontuacao()
    {
        List<int> Scores = new();
        Scores.Add(5);
        Scores.Add(1);
        Scores.Add(2);
        Scores.Add(3);
        Scores.Add(4);

        Console.WriteLine($"High number {Scores.Max()}, last added {Scores.Last()}");

        Scores.Sort();
        Scores.Reverse();
        Console.WriteLine($"And the three highest scores are {Scores[0]}, {Scores[1]}, {Scores[2]}");

    }
}