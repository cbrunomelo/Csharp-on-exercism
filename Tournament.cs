using System.Collections.Generic;

public class Team : IComparable<Team>
{
    public string Name { get; set; }
    public int MatchesPlayed { get; set; }
    public int MatchesWon { get; set; }
    public int MatchesDrawn { get; set; }
    public int MatchesLost { get; set; }
    public int Points
    {
        get { return (MatchesWon * 3) + MatchesDrawn; }

    }

    public int CompareTo(Team? other)
    {
        if (Points == other.Points)
            return 0;
        if (Points > other.Points)
            return -1;
        return 1;
    }
}

public class Tally
{
    public List<Team> TeamList { get; set; } = new();

    public void AddTeam(Team team)
    {
        TeamList.Add(team);
    }
    public void Counting(Team one, Team two, string result)
    {
        one.MatchesPlayed++;
        two.MatchesPlayed++;
        if (result == "win")
        {
            one.MatchesWon++;
            two.MatchesLost++;
        }
        else if (result == "draw")
        {
            one.MatchesDrawn++;
            two.MatchesDrawn++;
        }
        else if (result == "loss")
        {
            one.MatchesLost++;
            two.MatchesWon++;
        }

    }

    public void ShowTally()
    {
        TeamList.Sort();
        Console.WriteLine("Team \t\t | MP |  W |  D |  L |  P");
        foreach (var time in TeamList)
            Console.WriteLine($"{time.Name}\t\t |  {time.MatchesPlayed} |  {time.MatchesWon} |  {time.MatchesDrawn} |  {time.MatchesLost} |  {time.Points}");
    }

}

