public enum EColorst
{
    black,
    brown,
    red,
    orange,
    yellow,
    green,
    blue,
    violet,
    grey,
    white
}

public class Resistor_Color_Trio
{
    public static string Resistence(string colorOne, string colorTwo, string zeros)
    {
        EColors ColorOne;
        EColors Colortwo;
        EColors Zeros;


        bool checkParseColorOne = Enum.TryParse(colorOne, true, out ColorOne);
        bool checkParseColorTwo = Enum.TryParse(colorTwo, true, out Colortwo);
        bool checkParseZeros = Enum.TryParse(zeros, true, out Zeros);

        if (checkParseColorOne && checkParseColorTwo && checkParseZeros)
        {
            int numberOne = (int)ColorOne;
            int numberTwo = (int)Colortwo;
            double zeross = Math.Pow(10, (double)Zeros);

            var result = ((10 * numberOne) + numberTwo) * zeross;

            return $"The value is {result}";
        }

        return "Colors not found";
    }





}