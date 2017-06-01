using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Problema8
    {
        public static int numar, putere,numarP;
        static void Main(string [] args)
        {
            numar = int.Parse(Console.ReadLine());
            putere = int.Parse(Console.ReadLine());
            numarP = 1;
            for (int i = 0; i < putere; i++)
            {
                numarP = numar * numarP;
            }
            Console.WriteLine(numarP);
            Console.ReadKey();
        }
    }
}
