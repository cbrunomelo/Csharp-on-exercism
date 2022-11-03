public enum EColors
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

public class Resistor_Color_Duo
{
    public static string Resistence(string colorOne, string colorTwo)
    {
        EColors ColorOne;
        EColors Colortwo;

        bool checkParseColorOne = Enum.TryParse(colorOne, true, out ColorOne);
        bool checkParseColorTwo = Enum.TryParse(colorTwo, true, out Colortwo);

        if (checkParseColorOne && checkParseColorTwo)
            return $"Resistence: {(int)ColorOne}{(int)Colortwo}";

        return "Colors not found";
    }
    public static string Resistence(string colorOne, string colorTwo, string colothree)
        => Resistence(colorOne, colorTwo);



}