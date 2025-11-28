using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobble_sort
{
    internal class Program
    {
        static int[] vettore = { 13, 6, 8, 10 };
        static void Main(string[] args)
        {
            bool scambio = true;
            ordina_bubble_sort(vettore, ref scambio);
            if (scambio) Console.WriteLine("il vettore è già ordinato");
            stampa(vettore);
        }

        public static void stampa(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                Console.Write(vettore[i].ToString() + " ");
            }
        }
        public static int[] ordina_bubble_sort(int[] vettore, ref bool scambio)
        {
            do
            {
                int temp;
                scambio = true;
                for (int i = 0; i < vettore.Length - 1; i++)
                {
                    int successivo = vettore[i + 1], precedente = vettore[i];
                    if (vettore[i] > vettore[i + 1])
                    {
                        temp = precedente;
                        precedente = successivo;
                        successivo = temp;
                        scambio = false;
                    }
                }
            }while (scambio);
            return vettore;
        }
    }
}
