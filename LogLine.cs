public class LogLine
{
    string a = "[INFO]: ";
    string b = "[WARNING]: ";
    string c = "[ERROR]: ";
    public void Message(string d)
    {
        if (d.Contains(a))
        {
            Console.WriteLine(d.Split(a, StringSplitOptions.RemoveEmptyEntries)[0].Trim());
        }
        if (d.Contains(b))
        {
            Console.WriteLine(d.Split(b, StringSplitOptions.RemoveEmptyEntries)[0].Trim());

        }
        if (d.Contains(c))
        {
            Console.WriteLine(d.Split(c, StringSplitOptions.RemoveEmptyEntries)[0].Trim());
        }

    }

    public void LogLevel(string d)
    {
        if (d.Contains(a))
        {
            Console.WriteLine("info");
        }
        if (d.Contains(b))
        {
            Console.WriteLine("warning");
        }
        if (d.Contains(c))
        {
            Console.WriteLine("error");
        }

    }
}