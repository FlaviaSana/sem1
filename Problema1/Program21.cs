using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program21
    {
        static void Main(string[] args)
        {
            int x, suma = 0,nr = 0;
            double ma=0;
            while ((x = int.Parse(Console.ReadLine())) != -1)
            {
                suma = suma + x;
                nr++;
            }
            ma = suma / nr;
            Console.WriteLine("Ma este: " + ma);
            Console.ReadKey();
        }
    }
}
