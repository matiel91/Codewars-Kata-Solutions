using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gauß_needs_help_
{
    /// <summary>
    /// >>Gauß needs help! (Sums of a lot of numbers).<< 

    ///Due to another of his misbehaved, the primary school's teacher of the young Gauß, 
    ///Herr J.G. Büttner, to keep the bored and unruly young schoolboy Karl Friedrich Gauss 
    ///busy for a good long time, while he teaching arithmetic to his mates, assigned him the problem of adding up 
    ///all the whole numbers from 1 through a given number n.
    ///Your task is to help the young Carl Friedrich to solve this problem as quickly as you can; 
    ///so, he can astonish his teacher and rescue his recreation interval.
    /// </summary>
    public class Kata
    {
        //First solution
        public static long? RangeSum(long n)
        {

            if (n == 0)
            {
                return null;
            }
            var sum = 0L;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        //2nd solution
        public static long? RangeSumWithMathFormula(long n)
        {
            if (n <= 0)
            {
                return null;
            }
            var sum = ((1+n)*n)/2;

            return sum;
        }
        //3rd solution
        public static long? RangeSumWithMathFormula2(long n)
        {
            return (n <= 0) ?  default(long) : ((1 + n) * n) / 2 ;
        }
    }
}
