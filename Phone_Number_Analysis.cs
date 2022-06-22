public enum EDialing_code
{
    New_York = 212,
    sao_paulo = 011,
    No_matches = 0
}

public class PhoneNumber
{
    public static (EDialing_code, bool, int) Analyze(string number)
    {
        EDialing_code Edialing_code = (EDialing_code)0;

        int dialing_code = Convert.ToInt32(number.Substring(0, 3));

        if (Enum.IsDefined(typeof(EDialing_code), dialing_code))
            Edialing_code = (EDialing_code)dialing_code;

        bool fake_number = Convert.ToInt32(number.Substring(4, 3)) == 555;
        int four_lastNumbers = Convert.ToInt32(number.Substring(8, 4));

        return (Edialing_code, fake_number, four_lastNumbers);

    }

    public static bool IsFake(string number) => Analyze(number).Item2;
}
