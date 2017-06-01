using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program18
    {
        static void Main(string[] args)
        {
            int x, suma = 0;
            suma = suma + x;
            while ((x = int.Parse(Console.ReadLine())) != -1)
            {
                suma = suma + x;
            }
            Console.WriteLine("Suma este: "+suma);
            Console.ReadKey();
        }
    }
}
