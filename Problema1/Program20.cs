using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program20
    {
        static bool isPrim(int x)
        {
            int nrDiv = 0;
            if (x < 2) return false;
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0) nrDiv++;
            }
            if (nrDiv == 0) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int x, nrPrime = 0;
            while ((x = int.Parse(Console.ReadLine())) != -1)
            {
                if (isPrim(x) == true) nrPrime++;
            }
                Console.WriteLine("In total sunt:"+nrPrime);
            Console.ReadKey();
        }
    }
}
