using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_37_bubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cognomi = { "ABALINTOAIE", "ANDRU", "BERRINO", "BRUZZONE", "CERATTO","CHIRIAC", "DALLORTO", "GAMBINO", "GIRAUDO", "GIRELLO", "GJINI","KARDASH", "KOPSHTI", "LERDA", "LUBATTI", "MAGLIANO", "MARTINA", "MO","PETRUCCI", "REALE", "SACCATO", "SINGH", "SIVERA" };
            string[] nomi = {"LAURA","EMANUEL","ALESSANDRO","ALESSANDRO","MATTIA","COSMIN","EDOARDO","VALENTINA","MATTEO","GABRIELE","ALESSIO","YEHOR","LUIS","GIACOMO","LORENZO","PIETRO","SAMUELE","NICOLO'","MATTEO","LEONARDO","KEVIN","KAMALPREET","ELEONORA"};
            stampa(cognomi, nomi, cognomi.Length);
            ordina(cognomi, nomi);
            Console.WriteLine();
            stampa(cognomi, nomi, cognomi.Length);
        }

        private static void ordina(string[] cognomi, string[] nomi)
        {
            bool scambi = false;
            do
            {
                scambi = false;
                for(int i = 0; i < cognomi.Length -1; i++)
                {
                    if (nomi[i].CompareTo(nomi[i+1])> 0 || nomi[i] == nomi[i+1] || cognomi[i].CompareTo(cognomi[i+1])>0)
                    {
                        scambiare(ref nomi[i], ref nomi[i + 1]);
                        scambiare(ref cognomi[i], ref cognomi[i + 1]);
                        scambi = true;
                    }
                }
            }while(scambi);
        }

        private static void scambiare(ref string v1,ref string v2)
        {
            string temp = v1;
            v1 = v2;
            v2 = temp;
        }

        private static void stampa(string[] cognomi, string[] nomi, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(cognomi[i].PadRight(15) + nomi[i]);
            }
        }
    }
}
