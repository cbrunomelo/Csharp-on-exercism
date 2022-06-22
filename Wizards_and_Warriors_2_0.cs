using System;

public static class GameMaster
{
    public static void Describe(character persona) => Console.WriteLine($"You're a level {persona.Level} {persona.Clas} with {persona.HitPoints} hit points.");

    public static void Describe(Destination city) => Console.WriteLine($"You've arrived at {city.Name}, which has {city.Inhabitants} inhabitants.");


    public static void Describe(ETravelMethod travelMode) => Console.WriteLine($"You're traveling to your destination on {travelMode}.");

    public static void Describe(character persona, Destination city, ETravelMethod travelMode)
    {
        Describe(persona);
        Describe(city);
        Describe(travelMode);
    }
    public static void Describe(character persona, Destination city) => Describe(persona, city, persona.TravelMode);

}
public enum ETravelMethod
{
    Horseback,
    Walking
}
public class character
{
    public int Level { get; set; }
    public string Clas { get; set; }
    public int HitPoints { get; set; }
    public ETravelMethod TravelMode { get; set; }

    public character(string clas, int level, int hitPoints)
    {
        Clas = clas;
        Level = level;
        HitPoints = hitPoints;
        TravelMode = (ETravelMethod)1;

    }

}

public class Destination
{
    public int Inhabitants { get; set; }
    public string Name { get; set; }

    public Destination(string name, int inhabitants)
    {
        Name = name;
        Inhabitants = inhabitants;
    }

}