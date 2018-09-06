using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerSeriesSumOfNumbers
{
    /// <summary>
    /// Given two integers a and b, which can be positive or negative, find the sum of all the numbers between including them too and return it. 
    /// If the two numbers are equal return a or b.
    /// Note: a and b are not ordered!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            Console.WriteLine(sum.GetSum(1, 0));
            Console.WriteLine(sum.GetSum(1, 2));
            Console.WriteLine(sum.GetSum(0, 1));
            Console.WriteLine(sum.GetSum(1, 1));
            Console.WriteLine(sum.GetSum(-1, 0));
            Console.WriteLine(sum.GetSum(1, 0));
            Console.WriteLine(sum.GetSum(-1, 2));
            Console.ReadLine();

        }
    }
    public class Sum
    {
        public int GetSum(int a, int b)
        {
            if (a == b) return a;
            var sum = 0;
            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
