using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES36NomiInBinario
{
    internal class Program
    {
        //ordinare i nomi in ordine crescente e vis.il binario corrispondente
        static string[] nomi = {"LAURA","LAA","EMANUEL","ALESSANDRO","MATTIA","COSMIN","EDOARDO","VALENTINA",
            "MATTEO","MARCO","GABRIELE","ALESSIO","YEHOR","LUIS","GIACOMO","LORENZO","PIETRO",
            "SAMUELE","NICOLO'","MATTEO","LEONARDO","KEVIN","KAMALPREET","ELEONORA"};
        static string[] Nomi_Binari = new string[nomi.Length];
        static void Main(string[] args)
        {
            int n = nomi.Length;
            ConvertiNomeInBinario(nomi, n, Nomi_Binari);
            ordinaVettori(nomi, Nomi_Binari);
            stampa(nomi, Nomi_Binari);
            Console.ReadKey();
        }

        public static void stampa(string[] nomi, string[] binari)
        {
            Console.WriteLine("NOMI IN BINARIO");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < nomi.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {nomi[i]}: {binari[i]}");
            }
        }

        public static void ordinaVettori(string[] vettore, string[] vettore_binario)
        {
            int i, j;
            int posMin;
            string temp1, temp2;
            for (i = 0; i < vettore.Length - 1; i++)
            {
                posMin = i;
                for (j = i + 1; j < vettore.Length; j++)

                {

                    if (vettore[j].CompareTo(vettore[posMin]) == -1)
                        posMin = j;
                }
                if (posMin != i)
                {
                    temp1 = vettore[i];
                    vettore[i] = vettore[posMin];
                    vettore[posMin] = temp1;

                    temp2 = vettore_binario[i];
                    vettore_binario[i] = vettore_binario[posMin];
                    vettore_binario[posMin] = temp2;
                }
            }
        }

        private static string[] ConvertiNomeInBinario(string[] nomi, int n, string[] binari)
        {
            for (int i = 0; i < n; i++)
            {
                binari[i] = nomeInBinario(nomi[i]);
            }
            return binari;
        }

        /// <summary>
        /// esamino ogni carattere del nome, lo converto in intero
        /// e lo trasformo in binario
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        private static string nomeInBinario(string nome)
        {
            string s = "";
            char c;
            for (int i = 0; i < nome.Length; i++)
            {
                c = nome[i];
                s = s + Binario((int)c) + " ";
            }
            return s;
        }

        private static string Binario(int c)
        {
            string b = "";
            int r;
            while (c != 0)
            {
                r = c % 2;
                b = r + b;
                c = c / 2;
            }
            return b;

        }
    }
}