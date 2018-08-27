using System;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_Odd_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            var kata = new Kata();
            int[] testInput = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            Console.WriteLine(kata.find_it(testInput));
        }
    }
}
