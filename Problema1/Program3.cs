using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program3
    {
        static int x, y, z, t;
        static int minim2(int x,int y)
        {
            if (x < y) return x;
            else return y;
            
        }
        static int minim3(int x,int y,int z)
        {
            if (minim2(x, y) < minim2(y, z)) return minim2(x, y);
            else return minim2(y, z);
        }
        static int minim4(int x,int y, int z, int t)
        {
            if (minim3(x, y, z) < minim3(y, z, t)) return minim3(x, y, z);
            else return minim3(y, z, t);
        }
        static void Main(string [] args)
        {
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());
            Console.WriteLine("Minimul a 2 numere=" + minim2(x, y));
            Console.WriteLine("Minimul a 3 numere=" + minim3(x, y, z));
            Console.WriteLine("Minimul a 4 numere=" + minim4(x, y, z, t));
            Console.ReadLine();
        }
    }
}
