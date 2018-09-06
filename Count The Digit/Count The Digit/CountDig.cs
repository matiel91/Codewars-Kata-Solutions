using System;
using System.Linq;

namespace Count_The_Digit
{
    /// <summary>
    /// Take an integer n (n >= 0) and a digit d (0 <= d <= 9) as an integer. 
    /// Square all numbers k (0 <= k <= n) between 0 and n. 
    /// Count the numbers of digits d used in the writing of all the k**2. 
    /// Call nb_dig (or nbDig or ...) the function taking n and d as parameters and returning this count.
    /// </summary>
    public class CountDig
    {
        /// <summary>
        /// First Solution
        /// </summary>
        /// <param name="n"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int NbDig(int n, int d)
        {
            //can use IEnumerable.Range(0, n)?
            var digit = Convert.ToString(d);
            var charDigit = Convert.ToChar(digit);
            var intArray = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                intArray[i] = (int)Math.Pow(i,2);
            }

            var resultString = string.Join("", intArray);
            var count = 0 ;
            //for (int i = 0; i < resultString.Length; i++)
            //{
            //    if(resultString[i]==charDigit) count++;
            //} //replaced by below
            count = resultString.Count(s => s == charDigit);
            
            return count;
        }
        /// <summary>
        /// Second solution
        /// </summary>
        /// <param name="n"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int NbDig2(int n, int d)
        {
         
            var count = Enumerable.Range(0, n + 1).Select(i => (i * i).ToString().Count(c => c - 48 == d)).Sum();

            return count;
        }
    }
}
