using System.Collections.Generic;

public class Robot
{
    public static Random random = new Random();
    public static List<NewRobot> Robots = new List<NewRobot>
    {
        new NewRobot("RX837"),
        new NewRobot("BC811"),
    };

    public static void CreatRobot() => Robots.Add(new NewRobot(GenerateName()));

    public static void ResetRobot(string robotName)
    {
        var robot = Robots.FirstOrDefault(x => x.Name == robotName);
        if (robot is not null)
            robot.Name = GenerateName();
        else
            throw new Exception("there is not a robot with this name");
    }
    public static string GenerateName()
    {
        string name;
        do
        {
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] numbers = "0123456789".ToCharArray();
            var randomNumbers = numbers.OrderBy(x => random.Next()).ToArray();
            var randomChars = chars.OrderBy(x => random.Next()).ToArray();
            name = $"{randomChars[0]}{randomChars[1]}{randomNumbers[0]}{randomNumbers[1]}{randomNumbers[2]}";
        } while (Robots.FirstOrDefault(x => x.Name == name) != null);
        return name;

    }

    public class NewRobot
    {
        public string Name { get; set; }

        public NewRobot(string name)
        {
            Name = name;
        }
    }
}