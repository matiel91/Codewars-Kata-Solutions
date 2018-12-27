using System;
using System.Collections.Generic;

namespace Kata
{
    /// https://www.codewars.com/kata/build-tower/csharp <> 6kyu
    ///Build Tower
    ///Build Tower by the following given argument:
    ////number of floors(integer and always greater than 0).
    ////Tower block is represented as *
    ////C#: returns a string[];
    ///
    public class Kata
    {
        //check if the number of flors is greater then 0
        //calculate number of chars in first floor
        //Create first floor with number of floor stars
        //Add first floor
        //Replace first and last element by space
        //Add to array
        public static string[] TowerBuilder(int v)
        {
            //check if the number of flors is greater then 0
            if (v < 1)
            {
                throw new NotImplementedException();
            }
            //calculate number of chars in first floor
            //Create first floor filledup with stars
            string[] result = new string[v];
            string firstFloor = new string('*', NumberOfCharsInFirstFloor(v));
            int j = 0;
            int k = firstFloor.Length - 1;
            //Add first floor to array
            result[v - 1] = firstFloor;
            for (int i = v - 2; i >= 0; i--)
            {
                //Replace first and last element by space
                firstFloor = firstFloor.Remove(j, 1).Insert(j, " ");
                j++;
                firstFloor = firstFloor.Remove(k, 1).Insert(k, " ");
                k--;
                //Add to array
                result[i] = firstFloor;
            }
            return result;

            

        }
        public static int NumberOfCharsInFirstFloor(int v)
        {
            if (v == 1)
            {
                return 1;
            }
            return 2 * v - 1;
        }

    }
}
