using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program38
    {
        static int[,] a;
        static int[,] b;
        static int n, m;
        public static void citire(int n, int m, int[,] a)
        {
            Console.Write("Introduceti numarul de linii:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de coloane:");
            m = int.Parse(Console.ReadLine());
            a = new int[n, m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            }
        }
        public static void afisare(int n, int m, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
        public static void adunare(int[,] a, int[,] b)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = a[i, j] + b[i, j];
                }
            }
        }
        static void Main(string[] args)
        {
            citire(n, m, a);
            citire(n, m, b);
            afisare(n, m, a);
            adunare(a, b);
            afisare(n, m, a);
            Console.ReadKey();
        }
    }
}
