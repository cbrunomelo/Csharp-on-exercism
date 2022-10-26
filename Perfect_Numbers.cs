public class PerfectNumbers
{


    public static string WhichCategory(int number)
    {

        var sumOfDividingNumbers = DivisoresNumbers(number).Sum();

        if (number > sumOfDividingNumbers)
            return "Deficient";

        else if (number < sumOfDividingNumbers)
            return "Abundant";

        return "Perfect";
    }



    public static List<int> DivisoresNumbers(int number)
    {

        List<int> numbers = new();

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                numbers.Add(i);
        }

        return numbers;
    }
}