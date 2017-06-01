using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program27
    {
        static void Main(string[] args)
        {
            int[] v = new int[7];
            int suma = 0, produs = 1, norma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                suma = suma + v[i];
                produs = produs * v[i];
                norma = norma + Math.Pow(v[i], 2);

            }
            Console.WriteLine("Suma este: "+suma+" Produsul este: "+produs)+" Norma este: "+ norma;
            Console.ReadKey();
        }
    }
}
