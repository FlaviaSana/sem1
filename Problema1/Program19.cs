using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program19
    {
        static void Main(string[] args)
        {
            int x;
            int minim = int.MaxValue;
            int maxim = int.MinValue;
            while((x = int.Parse(Console.ReadLine()))!=-1)
            {
                if (x < minim) minim = x;
                if (x > maxim) maxim = x;
            }
            Console.WriteLine("Minimul este: "+ minim +"Maximul este: "+maxim);
            Console.ReadKey();
        }
    }
}
