using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program41
    {
        static long factorial(long n)
        {
            if (n == 1)
                return 1;
            else return n * factorial(n - 1);
        }
        static void Main(string [] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n));
            Console.ReadKey();
        }
    }
}
