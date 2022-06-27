public enum EPlants
{
    Mercury,
    Venus,
    Earth,
    Mars,
    Jupiter,
    Saturn,
    Uranus,
    Neptune
}

public class SpaceAge
{
    public static string MyAgeInPlanet(double liveSeconds, int planetOption) => (EPlants)planetOption switch
    {
        EPlants.Mercury => $"{liveSeconds / (31557600 * 0.2408467)} Mercury-years old",
        EPlants.Venus => $"{liveSeconds / (31557600 * 0.61519726)} Venus-years old",
        EPlants.Earth => $"{liveSeconds / 31557600} Earth-years old",
        EPlants.Mars => $"{liveSeconds / (31557600 * 1.8808158)} Mars-years old",
        EPlants.Jupiter => $"{liveSeconds / (31557600 * 11.862615)} Jupter-years old",
        EPlants.Saturn => $"{liveSeconds / (31557600 * 29.447498)} Saturn-years old",
        EPlants.Uranus => $"{liveSeconds / (31557600 * 84.016846)} Uranus-years old",
        EPlants.Neptune => $"{liveSeconds / (31557600 * 164.79132)} Neptune-years old",
        _ => "No match for this number option"
    };





}