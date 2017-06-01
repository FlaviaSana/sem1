using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program52
    {
        static Random rnd = new Random();
        static void Main(string [] args)
        {
            int x;
            int nrGhici = rnd.Next(0, 100);
            Console.WriteLine("Numarul de ghicit="+nrGhici);
            do
            {
                x = int.Parse(Console.ReadLine());
                if (x == nrGhici)
                {
                    Console.WriteLine("Felicitari ai ghiciti numarul!");
                }
                else if (x < nrGhici)
                {
                    Console.WriteLine("Numarul introdus este mai mic decat valoarea cautata!");
                }
                else if (x > nrGhici)
                {
                    Console.WriteLine("Numarul introdus este mai mare decat valoarea cautata!");
                }
            } while (x != nrGhici);
            Console.ReadKey();
        }
    }
}
