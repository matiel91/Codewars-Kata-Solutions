using Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Kata.Kata.TowerBuilder(4))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
