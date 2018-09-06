using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Count_The_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = new CountDig();
            Console.WriteLine(count.NbDig(20, 1));
            Console.WriteLine(count.NbDig2(20, 1));
            Console.ReadLine();
        }
    }
}
