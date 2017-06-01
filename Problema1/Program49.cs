using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problema1
{
    class Program49
    {
        static void Main(string [] args)
        {
            TextReader tReader = new StreamReader(@"C:\Users\Sebastian\Desktop\Probleme Laborator\Problema1\Files\Program49.txt");
            string s;
            int nrC = 0;
            s = tReader.ReadLine();
            while (s != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsLetter(s[i])) nrC++;
                }
                s = tReader.ReadLine();
            }
            Console.WriteLine("Numarul de caractere este: {0} ",nrC);
            Console.ReadKey();
        }
    }
}
