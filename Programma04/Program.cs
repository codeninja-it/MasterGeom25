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
            mappa.nodi.Add( new Nodo(1, "Firenze", "", 11.2558f, 43.7695f) );
            mappa.nodi.Add( new Nodo(2, "Bologna", "", 11.33875f, 44.49381f) );
            mappa.nodi.Add( new Nodo(3, "Roma", "", 12.51133f, 41.89193f) );

            mappa.Connetti(
                mappa.nodi.First(n => n.Nome == "Roma"),
                mappa.nodi.First(n => n.Nome == "Firenze")
            );

            mappa.Connetti(
                mappa.nodi.First(n => n.Nome == "Firenze"),
                mappa.nodi.First(n => n.Nome == "Bologna")
            );

            mappa.Salva("stradario.json");
        }
    }
}
