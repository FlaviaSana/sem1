using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program10
    {
        static void Main(string[] args)
        {
            int x, sum = 0;
            x = int.Parse(Console.ReadLine());
            sum = (x * (x +1)) / 2;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
