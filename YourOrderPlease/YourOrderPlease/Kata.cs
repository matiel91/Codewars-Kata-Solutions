using System;
using System.Collections.Generic;
using System.Linq;

namespace YourOrderPlease
{
    public static class Kata
    {
        /// <summary>
        /// Method task is to sort a given string words. 
        /// Each word in the String will contain a single number. 
        /// This number is the position the word should have in the result.
        /// </summary>
        /// <param name="words"></param>
        /// <returns>Sorted string</returns>
        public static string Order(string words)
        {
            var wordsSeparated = words.Split(' ');
            var list = new Dictionary<int, string>();
            var index = 0;
            for (int i = 0; i < wordsSeparated.Length; i++)
            {
                var splitWordsSeparated = wordsSeparated[i].ToCharArray();
        
                foreach(var item in splitWordsSeparated)
                {
                    var isNumber = int.TryParse(item.ToString(), out index);
                    //Console.WriteLine(item);
                    if (isNumber)
                    {
                        if (!list.Keys.Contains(index))
                        {
                            list.Add(index, wordsSeparated[i]);
                            continue;
                        }
                    }
                }
            }

            var items = from keys in list
                        orderby keys.Key ascending
                        select keys.Value;

            string finalString = String.Join(" ", items);

            return finalString;

            //throw new NotImplementedException();
        }
        /// <summary>
        /// Second shorter solution
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string Order2(string words)
        {
            if (string.IsNullOrEmpty(words))
            {
                return words;
            }

            return string.Join(" ", words.Split(' ')
                .OrderBy(s => s.ToList()
                .Find(c => char.IsDigit(c)))); 
        }
    }
}
