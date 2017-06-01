using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Problema4
    {
        static int[] v = new int[5];
        static int numar;
        static void Main(string[] args)
        {

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < v.Length-1; i++)
            {
                if (v[i] == v[i + 1]) numar++;
            }
            switch(numar)
            {
                case 0:
                    Console.WriteLine("Nu exista valori identice!");
                    break;
                case 1:
                    Console.WriteLine("Exista 2 valori identice");
                    break;
                case 2:
                    Console.WriteLine("Exista 3 valori identice");
                    break;
                case 3:
                    Console.WriteLine("Exista 4 valori identice");
                    break;
                case 4:
                    Console.WriteLine("Toate valorile sunt identice!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
