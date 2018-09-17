using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBigerNumberWithTheSameDigits.Core
{
    /// <summary>
    /// /:\/:\Next bigger number with the same digits/:\4kyu/:\
    /// You have to create a function that takes a positive integer number and returns the next bigger number formed by the same digits
    /// </summary>
    public static class Kata
    {
        /// <summary>
        /// Method is creating list of higher number by switching place of bigger digit in lower row with smaller digit in higher row, 
        /// and ordering asceding digits placed after the bigger digit. Smallest number(next one from the input number) from list is return.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Next bigger number </returns>
        public static long NextBiggerNumber(long input)
        {
            List<long> inputList = new List<long>();
            var inputString = input.ToString();
            List<long> higherNumbers = new List<long>();
            //List of digits in input
            for (int i = 0; i < inputString.Length; i++)
            {
                inputList.Add(long.Parse(inputString[i].ToString()));
            }
            for (int i = input.ToString().Length - 1; i > 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (inputList[i] <= inputList[j]) continue;
                    else
                    {
                        //Relocate higher digit to higher row
                        long numToRel = inputList[i];
                        var tempInputList = new List<long>();
                        tempInputList.AddRange(inputList);
                        tempInputList.RemoveAt(i);
                        tempInputList.Insert(j, numToRel);
                        //Order asceding digits placed after the bigger digit
                        var begList = tempInputList.Take(j+1);
                        var endList = tempInputList.Skip(j+1).OrderBy(x => x);
                        //Join begining of List with end of List
                        var resultIenum = begList.Concat(endList);
                        //Create result 
                        var result = long.Parse(string.Join("", resultIenum));
                        higherNumbers.Add(result);
                        break;
                    }
                }
            }           
            return higherNumbers.Count == 0 ? -1 : higherNumbers.Min();
        }


    }
}
