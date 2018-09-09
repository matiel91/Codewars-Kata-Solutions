using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MexicanWave
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            List<string> list = kata.Wave("example");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
