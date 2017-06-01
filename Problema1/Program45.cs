using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program45
    {
        static void generareMatrice(int i,int n)
        {
            if (i == n) return;
            else
            {
                for (int h = 0; h < n; h++)
                {
                    Console.Write("a[{0},{1}] ", i, h);
                }
                Console.WriteLine();
                generareMatrice(i + 1, n);
            }
        }
        static void Main(string [] args)
        {
            int i = 0, n;
            n = int.Parse(Console.ReadLine());
            generareMatrice(i, n);
            Console.ReadKey();
        }
    }
}
