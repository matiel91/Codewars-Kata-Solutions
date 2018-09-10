using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergedStringChecker.Core
{
    /// <summary>
    /// At a job interview, you are challenged to write an algorithm to check if a given string, s, can be formed from two other strings, part1 and part2.
    /// The restriction is that the characters in part1 and part2 are in the same order as in s.
    /// The interviewer gives you the following example and tells you to figure out the rest from the given test cases.
    /// </summary>
    public static class StringMerger
    {
        public static bool isMerge(string r, string p1, string p2)
        {
            if (r.Length != p1.Length + p2.Length)
            {
                return false;
            }
            //CHECK WORD FROM END
            if (CheckWord(ReverseString(r), ReverseString(p1), ReverseString(p2)))
            {
                return true;
            }
            if (CheckWord(ReverseString(r), ReverseString(p2), ReverseString(p1)))
            {
                return true;
            }
            // CHECK WORD FROM BEGINING
            if (CheckWord(r, p1, p2))
            {
                return true;
            }
            if (CheckWord(r, p2, p1))
            {
                return true;
            }
            //CHECK AND RETURN TO PART1 AFTER ONE MARK
            if (CheckWordAndReturnToPart1AfterOneMark(ReverseString(r), ReverseString(p1), ReverseString(p2)))
            {
                return true;
            }
            if (CheckWordAndReturnToPart1AfterOneMark(ReverseString(r), ReverseString(p2), ReverseString(p1)))
            {
                return true;
            }
            if (CheckWordAndReturnToPart1AfterOneMark(r, p1, p2))
            {
                return true;
            }
            if (CheckWordAndReturnToPart1AfterOneMark(r, p2, p1))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method first compare part1 to s, if chars are NOT equal, then compare part2 to s. If chars are equal it continue compare part2 to s till false.
        /// </summary>
        public static bool CheckWord(string s, string part1, string part2)
        {
            while (s.Length != 0)
            {
                if (part1.Length > 0 && s[0] == part1[0])
                {
                    while (part1.Length > 0 && s[0] == part1[0])
                    {
                        s = s.Remove(0, 1);
                        part1 = part1.Remove(0, 1);
                    }
                }
                else if (part2.Length > 0 && s[0] == part2[0])
                {
                    while (part2.Length > 0 && s[0] == part2[0])
                    {
                        s = s.Remove(0, 1);
                        part2 = part2.Remove(0, 1);
                    }
                }
                else
                {
                    break;
                }
            }
            if (s.Length == 0 && part1.Length == 0 && part2.Length == 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method first compare part1 to s, if chars are NOT equal, then compare part2 to s. If chars are equal it come back to compare part1
        /// </summary>
        public static bool CheckWordAndReturnToPart1AfterOneMark(string s, string part1, string part2)
        {
            while (s.Length != 0)
            {
                if (part1.Length > 0 && s[0] == part1[0])
                {
                    while (part1.Length > 0 && s[0] == part1[0])
                    {
                        s = s.Remove(0, 1);
                        part1 = part1.Remove(0, 1);
                    }
                }
                else if (part2.Length > 0 && s[0] == part2[0])
                {
                    int counter = 0;
                    while (part2.Length > 0 && s[0] == part2[0]&&counter<1)
                    {
                        s = s.Remove(0, 1);
                        part2 = part2.Remove(0, 1);
                        counter++;
                    }
                }
                else
                {
                    break;
                }
            }
            if (s.Length == 0 && part1.Length == 0 && part2.Length == 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Creating reverse of input string "abc" -> "cba"
        /// </summary>
        /// <param name="str">Input string</param>
        public static string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }
    }
}
