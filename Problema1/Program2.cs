using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program2
    {
        static double gradeC, gradeF;
        static void Main(string[] args)
        {
            gradeC = int.Parse(Console.ReadLine());
            gradeF = gradeC * 9 / 5 + 32;
            Console.WriteLine(gradeF);
            Console.ReadLine();
        }
    }
}
