using System;

namespace ExInterest
{
    public class SavingsAccount
    {

        static public float InterestRate(decimal balance)
        {
            if (balance < 0) return 3.213f;
            else if (balance >= 0 && balance < 1000) return 0.5f;
            else if (balance >= 100 && balance < 5000) return 1.621f;
            else return 2.475f;


        }

        static public decimal Interest(decimal balance)
        {
            return balance * (decimal)InterestRate(balance) / 100;
        }

        static public decimal AnnualBalanceUpdate(decimal balance)
        {
            return balance + Interest(balance);
        }

        static public int YearsBeforeDesiredBalance(decimal balance, int desire)
        {
            
            var CurrentBalance = balance;
            int years = 0;
            do
            {
                CurrentBalance = AnnualBalanceUpdate(CurrentBalance);
                years++;
            } while (desire > CurrentBalance);

            return years;
        }
    }

}