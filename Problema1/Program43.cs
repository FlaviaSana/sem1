using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program43
    {
        static int[] v = new int[5];
        static void citire(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("v[{0}]=", i);
                v[i] = int.Parse(Console.ReadLine());
            }
        }
        static void afisare(int[] v)
        {

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        private static void bubblesort(int[] v,int first, int last)
        {
            if (first < last && last > 0)
            {
                if (v[first] > v[first + 1])
                {
                    int aux = v[first];
                    v[first] = v[first + 1];
                    v[first + 1] = aux;
                }
                bubblesort(v, first + 1, last);
                bubblesort(v, first, last - 1);
            }
            else return;
        }

        static void Main(string [] args)
        {
            citire(v);
            afisare(v);
            bubblesort(v,0,v.Length-1);
            Console.WriteLine();
            afisare(v);
            Console.ReadKey();
        }
    }
}
