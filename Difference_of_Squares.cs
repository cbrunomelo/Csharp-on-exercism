public static class DifferenceOfSquares
{

    public static double Difference(int number)
    {
        return Math.Abs(SquareOfTheSum(number) - SumOfTheSquares(number));
    }

    public static double SquareOfTheSum(int number)
    {   
        int sum = 0;
        for(int i=0; i <= number; i++  )
        {
            sum += i;
        }

        return Math.Pow(sum,2);
    }

    public static double SumOfTheSquares(int number)
    {
        double sum = 0;
        for (int i = 0; i <= number; i++)
        {
            sum += Math.Pow(i, 2);
        }

        return sum;
    }
}
