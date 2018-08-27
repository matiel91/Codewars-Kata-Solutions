using System.Collections.Generic;
using System.Linq;

namespace Find_The_Odd_Int
{
    /// <summary>
    /// TASK:
    /// Given an array, find the int that appears an odd number of times.
    /// There will always be only one integer that appears an odd number of times.
    /// </summary>
    public class Kata
    {
        public int find_it(int[] seq)
        {
            //for avoid checking twice same number
            var dictionary = new Dictionary<int, int>();
            int result=-1;
            foreach (var item in seq)
            {
                //for avoid checking twice same number
                if (dictionary.ContainsKey(item))
                {
                    continue;
                }
                dictionary.Add(item, 0);
                //how to increase velue in dictionary
                var count = seq.Where(i => i == item).Count();
                if (count % 2 == 1)
                {
                    return result = item;
                }

            }
            return result;
        }
    }
}
