using System;
using System.Collections.Generic;
using System.Text;

namespace MexicanWave
{
    /// <summary>
    /// In this simple Kata your task is to create a function that turns a string into a Mexican Wave. 
    /// You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up. 
    /// 
    /// Example:
    /// wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]
    /// </summary>
    public class Kata
    {
        public List<string> Wave(string str)
        {
            List<string> list = new List<string>();
            StringBuilder sB = new StringBuilder(str);
            var strArray = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (strArray[i] == ' ') continue;
                strArray[i] = Convert.ToChar(strArray[i].ToString().ToUpper());
                list.Add(new string(strArray));
                strArray[i] = Convert.ToChar(strArray[i].ToString().ToLower());

            }

            return list;
        }
    }
}
