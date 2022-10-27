public class CollatzConjecture
{
    public static int Result(int number)
    {
        //é divisivel por 2
        //divde por 2
        //se nao mutiplica por 3 e adciona um
        //divide por 2
        //repeat
        int i = 0;
        while (number > 1)
        {
            if (number % 2 == 0)
            {
                i++;
                number /= 2;
                continue;
            }

            number = ((number * 3) + 1) / 2;
            i+=2;
        }

        return i;
    }
}
