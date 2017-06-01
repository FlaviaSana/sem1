using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Problema5
    {
        static double delta, x1, x2;
        static int a, b, c;
        static void Main(string[] args)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Solutiile ecuatiei de gradul 2 sunt sunt:{0} si {1}", x1, x2);
            }
            else if (delta < 0)
            {
                Console.WriteLine("Ectuatia nu are solutii reale");
            }
            else if (delta == 0)
            {
                x1 = x2 = (-b) / (2 * a);
                Console.WriteLine("Solutiile ecuatiei de gradul 2 sunt sunt:{0} si {1}", x1, x2);
            }
            Console.ReadKey();
        }

    }
}
