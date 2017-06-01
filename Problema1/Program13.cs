using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program13
    {
        static void Main(string [] args)
        {
            int x, suma=0;
            x = int.Parse(Console.ReadLine());
            while(x!=0)
            {
                suma = suma + x % 10;
                x = x / 10;
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
