using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program53
    {
        static int[] aparitii = new int[10];
        static int x, i, numarGenerat;
        static Random rnd = new Random();
        static void Main(string [] args)
        {
            Console.Write("Introduceti lungimea numarului: ");
            int numar = int.Parse(Console.ReadLine());
            while(numar!=0)
            {
                x = rnd.Next(0, 10);
                if(aparitii[x]==0)
                {
                    aparitii[x] = 1;
                    numarGenerat = numarGenerat * 10 + x;
                    numar--;
                }
            }
            Console.WriteLine(numarGenerat);
            Console.ReadKey();
        }
    }
}
