using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Core
{
    /// <summary>
    /// Write a method highestRank(arr) (or highest-rank in clojure) which returns the number which is 
    /// most frequent in the given input array (or ISeq). 
    /// If there is a tie for most frequent number, return the largest number of which is most frequent.
    /// </summary>
    public static class Kata
    {
        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {                     
                if (resultDictionary.ContainsKey(arr[i]))
                {
                    resultDictionary[arr[i]] += 1; 
                }
                else
                {
                    resultDictionary.Add(arr[i], 1);
                }
            }

            int max = resultDictionary.Max(x => x.Value);
            var firstResult = resultDictionary.Where(d => d.Value == max);
            var finalResult = firstResult.Max(d => d.Key);
            return finalResult;
        }
    }
}
