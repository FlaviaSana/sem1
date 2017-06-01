using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Problema9
    {
        static void Main(string[] args)
        {
            int x, fact = 1; 
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadKey();
        }
    }
}
