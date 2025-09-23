using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programma04.Strutture
{
    internal class Percorso
    {
        public Percorso(Mappa mappa, Nodo attuale, Nodo target, Arco[] storia) {
            // se nessun ha trovato la soluzione
            if (!mappa.Trovato)
            {
                // se sono arrivato
                if (attuale == target)
                {
                    // avverto e stampo la soluzione
                    mappa.Trovato = true;
                    Console.WriteLine("Sono arrivato!");
                    // estraendo per ogni passaggio
                    foreach (Arco step in storia)
                    {
                        // i nodi da cui sono passato
                        Nodo p1 = mappa.nodi.First(n => n.IdNodo == step.da);
                        Nodo p2 = mappa.nodi.First(n => n.IdNodo == step.a);
                        // e stampandoli a schermo
                        Console.WriteLine($"{p1.Nome} -> {p2.Nome}");
                    }
                }
                else // altrimenti
                {
                    // cerco le strade successive che posso percorrere
                    Arco[] stradeSuccessive = mappa
                                                .archi
                                                .Where(a => a.da == attuale.IdNodo || a.a == attuale.IdNodo)
                                                .ToArray();
                    // e per ognuna di esse
                    foreach (Arco strada in stradeSuccessive)
                    {
                        // se non ci sono mai passato prima
                        if (!storia.Contains(strada))
                        {
                            // ne prendo il nodo
                            Nodo passoDopo = mappa
                                                .nodi
                                                .First(n => n.IdNodo == strada.a);
                            // aggiorno la mia storia
                            Arco[] aggiornamento = storia.Append(strada).ToArray();
                            // ed analizzo la nuova posizione del mio percorso
                            new Percorso(mappa, passoDopo, target, aggiornamento);
                        }
                    }
                }
            }
        }
    }
}
