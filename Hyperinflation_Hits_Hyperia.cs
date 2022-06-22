public static class CentralBank
{
    static public string DisplayDenomination(long a, long b)
    {


        try
        {
            return checked(a * b).ToString();
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }
    }

    static public string DisplayGDP(long a, long b)
    {
        return DisplayDenomination(a, b);
    }
}