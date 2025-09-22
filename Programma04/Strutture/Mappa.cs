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

        public Mappa() { 
            nodi = new List<Nodo>();
            archi = new List<Arco>();
        }

        public void Trova(Nodo da, Nodo a)
        {

        }

        public void Connetti(Nodo primo, Nodo secondo)
        {
            archi.Add( new Arco(primo, secondo) );
        }

        public void Salva(string dove)
        {
            string buffer = JsonSerializer.Serialize( this );
            File.WriteAllText(dove, buffer);
        }

        public static Mappa Leggi(string dove)
        {
            string buffer = File.ReadAllText(dove);
            return JsonSerializer.Deserialize<Mappa>(buffer);
        }

    }
}
