using System.Collections.Generic;

namespace CountCharactersInYourString
{
    /// <summary>
    /// Count characters in your string 
    /// The main idea is to count all the occuring characters(UTF-8) in string. 
    /// If you have string like this aba then the result should be { 'a': 2, 'b': 1 }
    /// What if the string is empty? Then the result should be empty object literal { }
    /// For C#: Use a Dictionary<char, int> for this kata!
    /// </summary>
    public class Kata
    {
        //1st
        public static Dictionary<char, int> Count(string str)
        {
            
            var strCharArray = str.ToCharArray();
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!dictionary.ContainsKey(strCharArray[i]))
                {
                    dictionary.Add(strCharArray[i], 1);
                    continue;
                }
                else
                {
                    dictionary.TryGetValue(strCharArray[i], out int value);                   
                    dictionary[strCharArray[i]] = ++value;
                }

            }
            return dictionary;
        }
        //2nd
        public static Dictionary<char, int> Count2(string str)
        {            
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!dictionary.ContainsKey(str[i]))
                {
                    dictionary.Add(str[i], 1);
                    continue;
                }
                else
                {
                    dictionary.TryGetValue(str[i], out int value);
                    dictionary[str[i]] = ++value;
                }

            }
            return dictionary;
        }
    }
}
