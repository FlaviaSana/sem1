using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program11
    {
        static void Main(string [] args)
        {
            int x, nrDiv=0;
            x = int.Parse(Console.ReadLine());
            for (int i = 2; i <= x/2; i++)
            {
                if (x % i == 0) nrDiv++;
            }
            if (nrDiv == 0) Console.WriteLine("Numarul este prim!");
            else Console.WriteLine("Numarul nu este prim!");
            Console.ReadKey();
        }
    }
}
