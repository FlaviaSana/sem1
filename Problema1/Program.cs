using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        public static int latura1, latura2, latura3, semiperimetrul;
        public static void ariaTriunghi()
        {
            double aria;
            aria = Math.Sqrt(semiperimetrul * (semiperimetrul - latura1) * (semiperimetrul - latura2) * (semiperimetrul - latura3));
            Console.WriteLine("Aria trunghiului este: "+aria);
        }
        static void Main(string[] args)
        {
            latura1 = int.Parse(Console.ReadLine());
            latura2 = int.Parse(Console.ReadLine());
            latura3= int.Parse(Console.ReadLine());
            semiperimetrul = (latura1 + latura2 + latura3) / 2;
            ariaTriunghi();
            Console.ReadKey();
        }
    }
}
