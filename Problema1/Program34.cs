using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program34
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
        static void adunareMatrici(int[,] a, int[,] b, int[,] c)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de linii:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de coloane:");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            int[,] b = new int[n, m];
            int[,] c = new int[n, m];
            citireMatrice(n, m, a);
            Console.WriteLine("Matricea a");
            afisareMatrice(n, m, a);
            citireMatrice(n, m, b);
            Console.WriteLine("Matricea b");
            afisareMatrice(n, m, b);
            adunareMatrici(a, b, c);
            Console.WriteLine("Matricea c");
            afisareMatrice(n, m, c);
            Console.ReadKey();
        }
    }
}
