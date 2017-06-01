using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problema1
{
    class Program47
    {
        static void Main(string [] args)
        {
            TextReader tReader = new StreamReader(@"C:\Users\Sebastian\Desktop\Probleme Laborator\Problema1\Files\Program47a.txt");
            TextWriter tWriter =new StreamWriter(@"C:\Users\Sebastian\Desktop\Probleme Laborator\Problema1\Files\Program47b.txt");
            string s;
            s = tReader.ReadLine();
            while(s!=null)
            {
                tWriter.WriteLine(s);
                s = tReader.ReadLine();
            }
            tReader.Close();
            tWriter.Close();
        }
    }
}
