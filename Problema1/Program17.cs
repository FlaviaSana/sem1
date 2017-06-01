using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program17
    {
        static void Main(string[] args)
        {
            int x, c;
            bool ok = true;
            x = int.Parse(Console.ReadLine());
            c = x % 10;
            x = x / 10;
            while (x != 0 && ok == true)
            {
                if (c > x % 10)
                {
                    c = x % 10;
                    x = x / 10;
                }
                else ok = false;
            }
            if(ok==true) Console.WriteLine("Numarul este ordonat crescator!");
            else Console.WriteLine("Numarul nu este ordonat crescator!");
            Console.ReadKey();
        }
    }
}
