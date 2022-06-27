public class Resistor_Color
{
    public enum EResistorColor
    {
        Black = 0,
        Brown = 1,
        Red = 2,
        Orange = 3,
        Yellow = 4,
        Green = 5,
        Blue = 6,
        Violet = 7,
        Grey = 8,
        White = 9
    }

    public static string WhatCodeIsThisColor(string color)
    {
        EResistorColor Color;
        if (Enum.TryParse(color, true, out Color))
            return $"The color code is {(int)Color}";
        return "No match";
    }

    public static List<string> ColorList()
    {
        List<string> ColorList = new();
        foreach (var color in Enum.GetNames(typeof(EResistorColor)))
            ColorList.Add(color);

        return ColorList;
    }
}