using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// https://www.codewars.com/kata/money-money-money/csharp -- 7kyu
/// Mr. Scrooge has a sum of money 'P' that wants to invest, and he wants to know how many years 'Y' this sum has to be kept in the bank in order for this sum of money to amount to 'D'.
///The sum is kept for 'Y' years in the bank where interest 'I' is paid yearly, and the new sum is re-invested yearly after paying tax 'T'
///Note that the principal is not taxed but only the year's accrued interest
///Your task is to complete the method provided and return the number of years 'Y' as a whole in order for Mr.Scrooge to get the desired sum.
/// </summary>
namespace MoneyMoneyMoney
{
    public static class Kata
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;
            while (principal < desiredPrincipal)
            {
                principal += principal * interest * (1 - tax);
                years++;
            }
            return years;
        }
    }
}
