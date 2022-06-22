public enum EPosisionts
{
    goalie,
    leftback,
    centerback,
    rightback,
    midfielder,
    leftwing,
    striker,
    rightwing

}

public class PlayAnalyzer
{
    public EPosisionts Position;
    public int ShirtNumber;

    public PlayAnalyzer(EPosisionts position, int shirtNumber)
    {
        this.Position = position;
        this.ShirtNumber = shirtNumber;
    }

    
}