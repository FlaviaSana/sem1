using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problema1
{
    class Program50
    {
        static void Main(string[] args)
        {
            TextReader tReader = new StreamReader(@"C:\Users\Sebastian\Desktop\Probleme Laborator\Problema1\Files\Program50.txt");
            string sirCautat = Console.ReadLine();
            int numar = 0;
            string s = tReader.ReadLine();
            int pozitie;
            while(s!=null)
            {
                pozitie = s.IndexOf(sirCautat, 0);
                while(pozitie!=-1)
                {
                    pozitie = s.IndexOf(sirCautat, pozitie + sirCautat.Length);
                    numar++;
                }
                s = tReader.ReadLine();
            }
            Console.WriteLine("Sirul {0} apare de {1} ori.",sirCautat,numar);
            Console.ReadKey();
        }
    }
}
