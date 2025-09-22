using Programma04.Strutture;
using System.Diagnostics;

namespace Programma04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mappa mappa = new Mappa();

            Nodo primo = new Nodo();
            primo.Nome = "Firenze";
            primo.Lat = 43.7695f;
            primo.Long = 11.2558f;

            mappa.nodi.Add(primo);

            mappa.Salva("regionetoscana.json");
        }
    }
}
