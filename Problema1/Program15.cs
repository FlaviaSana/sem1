using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program15
    {
        static void Main(string[] args)
        {
            int x, og=0;
            x = int.Parse(Console.ReadLine());
            while(x!=0)
            {
                og = og * 10 + x % 10;
                x = x / 10;
            }
            Console.WriteLine(og);
            Console.ReadKey();
        }
    }
}
