using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program39
    {
        public struct Complex
        {
            public int real;
            public int imaginar;
        }
        public static void citire(Complex a)
        {
            Console.Write("Coeficientul partii reale este: ");
            a.real = int.Parse(Console.ReadLine());
            Console.Write("Coeficientul partii imaginare este: ");
            a.imaginar = int.Parse(Console.ReadLine());
        }
        public static void afisare(Complex a)
        {
            Console.WriteLine("Partea reala este {0} si partea imaginara este {1}",a.real,a.imaginar);
        }
        static Complex adunareComplexa(Complex a,Complex b)
        {
            Complex suma = new Complex();
            suma.real = a.real + b.real;
            suma.imaginar = a.imaginar + b.imaginar;
            return suma;
        }
        static double normaComplexa(Complex a)
        {
            double norma = 0;
            norma = Math.Pow(a.real, 2) + Math.Pow(a.imaginar, 2);
            norma = Math.Sqrt(norma);
            return norma;
        }
        static Complex produsComplex(Complex a,Complex b)
        {
            Complex produs = new Complex();
            produs.real = a.real * b.real - a.imaginar * b.imaginar;
            produs.imaginar= a.real * b.real + a.imaginar * b.imaginar;
            return produs;
        }
        static void Main(string [] args)
        {
            Complex a = new Complex();
            Complex b = new Complex();
            Console.Write("Coeficientul partii reale este: ");
            a.real = int.Parse(Console.ReadLine());
            Console.Write("Coeficientul partii imaginare este: ");
            a.imaginar = int.Parse(Console.ReadLine());
            afisare(a);
            Console.Write("Coeficientul partii reale este: ");
            b.real = int.Parse(Console.ReadLine());
            Console.Write("Coeficientul partii imaginare este: ");
            b.imaginar = int.Parse(Console.ReadLine());
            afisare(b);
            Complex suma = adunareComplexa(a, b);
            Complex produs = produsComplex(a, b);
            double norma = normaComplexa(suma);
            Console.WriteLine("Suma este {0} + {1}i ",suma.real,suma.imaginar);
            Console.WriteLine("Produsul este {0} + {1}i ", produs.real, produs.imaginar);
            Console.WriteLine("Normal complexa este: "+ norma);
            Console.ReadKey();
        }
    }
}
