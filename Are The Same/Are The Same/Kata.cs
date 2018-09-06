using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Are_The_Same
{
    /// <summary>
    /// Given two arrays a and b write a function comp(a, b) (compSame(a, b) in Clojure) that checks whether 
    /// the two arrays have the "same" elements, with the same multiplicities.
    /// "Same" means, here, that the elements in b are the elements in a squared, regardless of the order.
    /// </summary>
    class Kata
    {

        public static bool comp(int[] a, int[] b)
        {

            if (a == null|| b == null) return false;
            var listA = a.ToList();
            var listB = b.ToList();
            var count = 0;
            //A block for preliminary checking if iterate is required
            //A 
            if (a.Length == 0 && b.Length == 0) return true;
            else if (a.Length == 0 || b.Length == 0) return false;            
            var diffrence = a.Select(i => i * i).Except(b);
            if (diffrence.Count() > 0) return false;
            //A
            for (int i = 0; i < listA.Count; i++)
            {
                count = 0;
                for (int j = 0; j < listB.Count; j++)
                {
                    if(Math.Pow(listA[i], 2) == listB[j])
                    {
                        listB.Remove(listB[j]);
                        count++;
                        continue;
                    }
                    if (count > 0) continue;
                }
                //if (count == 0) return false;
            }
            if(listB.Count>0) return false;

            return true;
        }
    }
}
