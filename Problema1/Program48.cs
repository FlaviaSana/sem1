using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problema1
{
    class Program48
    {
        static void Main(string [] args)
        {
            TextReader tReader = new StreamReader(@"C:\Users\Sebastian\Desktop\Probleme Laborator\Problema1\Files\Program48a.txt");
            TextWriter tWriter = new StreamWriter(@"C:\Users\Sebastian\Desktop\Probleme Laborator\Problema1\Files\Program48b.txt",true);
            string s = tReader.ReadLine();
            tWriter.WriteLine();
            while (s != null)
            {
                tWriter.WriteLine(s);
                s = tReader.ReadLine();
            }
            tReader.Close();
            tWriter.Close();
        }
    }
}
