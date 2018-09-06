using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Are_The_Same
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[0];
            int[] b = new int[0];
            int[] c = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] d = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            
            Console.WriteLine(Kata.comp(a, null));
            Console.WriteLine( Kata.comp(c, d));
            Console.ReadLine();


        }
    }

}
