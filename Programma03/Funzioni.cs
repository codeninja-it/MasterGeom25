using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programma03
{
    public class Funzioni
    {
        public static string Chiedi(string domanda)
        {
            Console.Write(domanda + ":\t");
            return Console.ReadLine();
        }

        public static void Tabellina()
        {
            // chiedo quale tabellina
            int numero = int.Parse(Chiedi("Quale tabellina?"));

            // ne chiedo anche la lunghezza
            int ripetizioni = int.Parse(Chiedi("Quante ripetizioni?"));

            // chiedo dove scaricare i dati
            string nomeFile = Chiedi("Dove lo salvo?");

            // inizializzo un buffer vuoto
            string buffer = "";
            // eseguo il mio ciclo
            for (int n = 0; n < ripetizioni; n = n + 1)
            {
                int risultato = numero * n;
                //Console.WriteLine(numero + " X " + n + " = " + risultato);
                //Console.WriteLine($"{numero} X {n} = {risultato}");
                buffer = buffer + $"{numero} X {n} = {risultato}\n";
            }
            // scarico i dati su disco
            File.WriteAllText(nomeFile, buffer);
        }
    }
}
