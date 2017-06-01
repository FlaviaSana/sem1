using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program22
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti textul dorit:");
            string s = Console.ReadLine();
            Console.Write("Introduceti carcaterul:");
            char c = char.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == c)
                    nr++;
            Console.WriteLine("Caracterul {0} apare de {1} ori", c, nr);
            Console.ReadKey();
        }
    }
}
