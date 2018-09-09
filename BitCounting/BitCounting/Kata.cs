using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BitCounting
{
    /// <summary>
    /// Write a function that takes an (unsigned) integer as input, and returns the number of bits that are equal to one in the binary representation of that number.
    ///Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
    /// </summary>
    public class Kata
    {
        public static int CountBits(int n)
        {
            var nBinary = Convert.ToString(n, 2);
            var count = nBinary.Count(s => s=='1');
            return count;            
        }
        public static int CountBits2(int n)
        {
            return Convert.ToString(n, 2).Count(s=>s=='1');
        }
    }
}
