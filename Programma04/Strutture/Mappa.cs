using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Programma04.Strutture
{
    internal class Mappa
    {
        public string nome { get; set; }
        public List<Nodo> nodi { get; set; }
        public List<Arco> archi { get; set; }
        public bool Trovato { get; set; } = false;

        public Mappa(string Nome) { 
            nodi = new List<Nodo>();
            archi = new List<Arco>();
            nome = Nome;
        }

        public List<Arco> Trova(Nodo da, Nodo a)
        {
            return archi;
        }

        public void Connetti(Nodo primo, Nodo secondo)
        {
            archi.Add( new Arco(primo, secondo) );
        }

        public void Salva(string dove)
        {
            JsonSerializerOptions opzioni = new JsonSerializerOptions();
            opzioni.WriteIndented = true;

            string buffer = JsonSerializer.Serialize(this , opzioni);
            File.WriteAllText(dove, buffer);
        }

        public static Mappa Leggi(string dove)
        {
            string buffer = File.ReadAllText(dove);
            return JsonSerializer.Deserialize<Mappa>(buffer);
        }

        public void ImportaNodi(string dove)
        {
            // mi assicuro che l'archivio sia vuoto
            nodi.Clear();
            // recupero le linee contenute nel file
            string[] linee = File.ReadAllLines(dove);
            // per ogni linea
            for(int i=1; i < linee.Length; i = i + 1)
            {
                // la prendo
                string linea = linee[i];
                // la divido in segmenti
                string[] pezzi = linea.Split('\t');
                // e la uso per creare un nuovo nodo in collezione
                nodi.Add( new Nodo(i, pezzi[0], float.Parse(pezzi[1]), float.Parse(pezzi[2])) );
            }
        }

        public void ImportaArchi(string dove)
        {
            archi.Clear();
            string[] linee = File.ReadAllLines(dove);
            for(int i=1; i < linee.Length; i = i + 1)
            {
                string linea = linee[i];
                string[] pezzi = linea.Split('\t');
                Nodo partenza = nodi.First(n => n.Nome == pezzi[0]);
                Nodo arrivo = nodi.First(n => n.Nome == pezzi[1]);
                archi.Add( new Arco(partenza, arrivo) );
                //archi.Add( new Arco(arrivo, partenza) );
            }
        }

    }
}
