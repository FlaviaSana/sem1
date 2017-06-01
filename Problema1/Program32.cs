using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program32
    {
        static int[] v = new int[5];
        static void citire(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("v[{0}]=", i);
                v[i] = int.Parse(Console.ReadLine());
            }
        }
        static void afisare(int[] v)
        {

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        static void insertionSort(int[] v)
        {
            for (int i = 1; i < v.Length; i++)
            {
                int aux = v[i];
                int j = i - 1;
                while (j >= 0 && v[j] > aux)
                {
                    v[j + 1] = v[j];
                    j--;
                }
                v[j + 1] = aux;
            }
        }
        static void selectionSort(int[] v)
        {
            int aux;
            for (int i = 0; i < v.Length-1; i++)
            {
                for (int j = i+1; j < v.Length; j++)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }
        static void selectionSortD(int[] v)
        {
            int poz_min, aux;
            for (int i = 0; i < v.Length-1; i++)
            {
                poz_min = i; //Fixam in poz_min indicele vectorului
                for (int j = i+1; j < v.Length; j++)
                {
                    if (v[j] < v[poz_min])
                    {
                        poz_min = j;
                        //Salvam in poz_min indicele care are valoarea minima.
                    }
                }
                if(poz_min!=i) // Daca poz_min este diferita de valoarea lui i inseamna ca s-a gasit o valoare mai mica
                {
                    aux = v[i];
                    v[i] = v[poz_min];
                    v[poz_min] = aux;
                }
            }
        }
        static void bubbleSort(int[] v)
        {
            int aux;
            bool ok = true;
            do
            {
                ok = true;
                for (int i = 0; i < v.Length - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = false;
                    }

                }
            } while (ok == false);

        }
        static void Main(string [] args)
        {
            citire(v);
            afisare(v);
            //insertionSort(v);
            //selectionSort(v);
            //selectionSortD(v);
            bubbleSort(v);
            Console.WriteLine();
            afisare(v);
            Console.ReadKey();
        }

    }
}
