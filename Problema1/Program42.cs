using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program42
    {
        private static int Fibonacci(int n)
        {
            if (n < 2) return n;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
                    
        }
        static void Main(string [] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadKey();

        }
    }
}
