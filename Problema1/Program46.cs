using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problema1
{
    class Program46
    {
        static void Main(string [] args)
        {
            TextReader line = new StreamReader(@"C:\Users\Sebastian\Desktop\Probleme Laborator\Problema1\Files\Program46.txt");
            int n = int.Parse(line.ReadLine());
            int[] v = new int[n];
            string [] s = line.ReadLine().Split(' ');
            int i = 0;
            foreach(var item in s)
            {
                v[i] = int.Parse(s[i]);
                i++;
            }
            for (i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.ReadKey();

        }
    }
}
