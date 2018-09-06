using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cata.DescendingOrder(124356879));
            Console.ReadLine();
        }
    }
    /// <summary>
    /// Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order.
    /// </summary>
    public static class Cata
    {
        
        public static int DescendingOrder(int num)
        {
            //Convert int to String
            var strNum = num.ToString();
            //creating char array with num digits
            var charNum = strNum.ToCharArray();
            //adding and parsing each element to list 
            var intList = new List<int>();
            
            foreach (var item in charNum)
            {
                intList.Add(int.Parse(item.ToString()));
            }
            //sorting a list descending
            intList = intList.OrderByDescending(x => x).ToList();
            var intArray = intList.ToArray();         
            return int.Parse(String.Join("", intArray.Select(x => x.ToString())));
        }
    }
}
