using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Problema6
    {
        public static int x;
        public static int f(int x)
        {
            if (x < 3) return x * x;
            else return x + 1;
        }
        static void Main(string[] args)
        {
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma este: {0}", f(x));
            Console.ReadKey();
        }
    }
}
