using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program23
    {
        static int strlen(StringBuilder s)
        {
            int nr = 0;
            foreach(char c in s.ToString())
                nr++;
            return nr;
        }
        static void strcpy(StringBuilder s,StringBuilder s1)
        {
            s.Length = s1.Length;
            for (int i = 0; i < s1.Length; i++)
            {
                s[i] = s1[i];
            }
        }
        static void strcat(StringBuilder s,StringBuilder s1)
        {
            int n = s.Length;
            s.Length = s.Length + s1.Length;
            for (int i = n; i < s.Length; i++)
            {
                s[i] = s1[i - n];
            }
        }
        static void strncat(StringBuilder s,StringBuilder s1,int j)
        {
            s.Length = s.Length + j;
            for (int i = 0; i < j; i++)
            {
                s[s.Length - j + i] = s1[i];
            }

        }
        static void Main(string [] args)
        {
            Console.Write("Introduceti un sir de carctere:");
            StringBuilder s = new StringBuilder(Console.ReadLine(), 1000);
            Console.Write("introduceti un sir de carctere:");
            StringBuilder s1 = new StringBuilder(Console.ReadLine(), 1000);     
            Console.WriteLine("Sirul contine {0} caractere",strlen(s));
            //strcpy(s, s1);
            //Console.WriteLine("Noul sir s este> "+s);
            //strcat(s, s1);
            //Console.WriteLine("Sirul s concatenat cu s1 este: "+ s);
            strncat(s, s1, 3);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
