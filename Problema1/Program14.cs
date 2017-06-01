using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program14
    {
        static void Main(string[] args)
        {
            int x, minim;
            minim = 10;
            x = int.Parse(Console.ReadLine());
            while(x!=0)
            {
                if (minim > x % 10) minim = x % 10;
                x = x / 10;
            }
            Console.WriteLine(minim);
            Console.ReadKey();
        }
    }
}
