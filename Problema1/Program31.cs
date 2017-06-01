using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program31
    {
        static int[] v = new int[5];
        static void citire(int []v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("v[{0}]=", i);
                v[i] = int.Parse(Console.ReadLine());
            }
        }
        static void afisare(int [] v)
        {

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        public static void bubbleSort(int [] v)
        {
            int aux;
            bool ok = true;
            do
            {
                ok = true;
                for (int i = 0; i < v.Length - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = false;
                    }

                }
            } while (ok == false);

        }
        static void Main(string [] args)
        {
            //Console.Write("Introduceti numarul de elemente al vectorului:");
            // int n = int.Parse(Console.ReadLine());
            citire(v);
            afisare(v);
            bubbleSort(v);
            Console.WriteLine();
            afisare(v);

            Console.ReadKey();
        }
    }
}
