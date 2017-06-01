using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program28
    {
        static void Main(string[] args)
        {
            int[] v = new int[7];
            int minim = int.MaxValue;
            int maxim = int.MinValue;
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > maxim) maxim = v[i];
                if (v[i] < minim) minim = v[i];
            }
            Console.WriteLine("Minim={0} si Maximul={1}", minim, maxim);
            Console.ReadKey();
        }
    }
}
