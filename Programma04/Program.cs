using Programma04.Strutture;
using System.Diagnostics;

namespace Programma04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mappa mappa = new Mappa("stradario italia 2025");
            // costruisco e immetto in mappa un nodo
            mappa.ImportaNodi("nodi.txt");
            mappa.ImportaArchi("archi.txt");
            // salvo il file sul disco
            mappa.Salva("stradario.json");
            // e calcolo il percorso
            string partenza = Chiedi("Dove vuoi andare");
            string arrivo = Chiedi("Qual'è la tua destinazione");
            new Percorso(
                mappa,
                mappa.nodi.First(n => n.Nome == partenza),
                mappa.nodi.First(n => n.Nome == arrivo),
                new Arco[0]
                );
        }

        static string Chiedi(string domanda)
        {
            Console.Write(domanda + ":\t");
            return Console.ReadLine();
        }
    }
}
