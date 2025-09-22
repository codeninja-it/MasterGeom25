using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programma04.Strutture
{
    public class Nodo
    {
        public int IdNodo { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public float Lat { get; set; }
        public float Long { get; set; }

        /*
         * CREATE TABLE IF NOT EXISTS nodi (
         *  idnodo int primary key autoincrement,
         *  nome text,
         *  descrizione text,
         *  lat float,
         *  lon float
         * ); 
         */

        public float Distanza(Nodo target)
        {
            // TODO: cacolo della distanza
            return 0; 
        }
    }
}
