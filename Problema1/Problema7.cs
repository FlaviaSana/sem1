using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Problema7
    {
        public static int x, y, z, aux;
        static void Main(string [] args)
        {
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            if(y<x)
            {
                aux = x;
                x = y;
                y = aux;
            }
            if(z<x)
            {
                aux = x;
                x = z;
                z = aux;
            }
            if(z<y)
            {
                aux = z;
                z = y;
                y = aux;
            }
            Console.WriteLine("Numerele sunt: {0}, {1}, {2}",x, y, z);
            Console.ReadKey();
        }
    }
}
