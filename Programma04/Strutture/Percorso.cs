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
            if (!mappa.Trovato)
            {
                if (attuale == target)
                {
                    mappa.Trovato = true;
                    Console.WriteLine("Sono arrivato!");
                    foreach (Arco step in storia)
                    {
                        Nodo p1 = mappa.nodi.First(n => n.IdNodo == step.da);
                        Nodo p2 = mappa.nodi.First(n => n.IdNodo == step.a);
                        Console.WriteLine($"{p1.Nome} -> {p2.Nome}");
                    }
                }
                else
                {
                    Arco[] stradeSuccessive = mappa
                                                .archi
                                                .Where(a => a.da == attuale.IdNodo || a.a == attuale.IdNodo)
                                                .ToArray();
                    foreach (Arco strada in stradeSuccessive)
                    {
                        if (!storia.Contains(strada))
                        {
                            Nodo passoDopo = mappa
                            .nodi
                            .First(n => n.IdNodo == strada.a);
                            Arco[] aggiornamento = storia.Append(strada).ToArray();
                            new Percorso(mappa, passoDopo, target, aggiornamento);
                        }
                    }
                }
            }
        }
    }
}
