using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program44
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
        static void functFor(int i, int [] v)
        {
            if (i == v.Length) return;
                Console.WriteLine(v[i]);
                functFor(i + 1, v);
           
        }
        static void Main(string [] args)
        {
            citire(v);
            afisare(v);
            Console.WriteLine();
            int i = 0;
            functFor(i, v);
            Console.ReadKey();
        }
    }
}
