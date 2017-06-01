using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program16
    {
        static int Palindrom(int x)
        {
            int og = 0;
            while (x != 0)
            {
                og = og * 10 + x % 10;
                x = x / 10;
            }
            return og;
        }
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            if (x == Palindrom(x))
                Console.WriteLine("Este palindrom!");
            else
                Console.WriteLine("Nu este palindrom!");
            Console.ReadKey();
        }
    }
}
