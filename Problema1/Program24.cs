using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program24
    {
        static void Main(string [] args)
        {
            string s="";
            char c;
            while((c = char.Parse(Console.ReadLine()))!='0')
            {
                s = s + c;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
