public class Player
{

    public double MyStrength = 0;
    public Random Random = new Random();
    public int Roll() => Random.Next(1, 19);

    public double GenerateSpellStrength()
    {
        double number = Random.Next(10, 1001);
        MyStrength = number / 10;
        return MyStrength;
    }

}