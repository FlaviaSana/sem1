using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program33
    {
        static int n, m;
        static void citireMatrice(int n, int m, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());

                }
            }
        }
        static void afisareMatrice(int n, int m, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de linii:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de coloane:");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            citireMatrice(n, m, a);
            afisareMatrice(n, m, a);
            int det= a[0, 0] * a[1, 1] * a[2, 2] + a[1, 0] * a[2, 1] * a[0, 2] + a[2, 0] * a[0, 1] * a[1, 2] - a[0, 2] * a[1, 1] * a[2, 0] - a[1, 2] * a[2, 1] * a[0, 0] - a[2, 2] * a[0, 1] * a[1, 0];
            Console.WriteLine("Determinantul matricei este: "+det);
            Console.ReadKey();
        }
    }
}
