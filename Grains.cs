public class Grains
{
    public static double HowManyGrainsInSquare(int square)
    =>  Math.Pow(2, (square - 1));
    

    public static double HowManyGrainsInTotal()
    {
        double total = (Math.Pow(2, 64) - 1); //soma de uma PG
        return total;
    }
}