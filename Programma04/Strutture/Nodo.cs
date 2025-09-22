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
        public float Y { get; set; }
        public float X { get; set; }
        public DateTime Creazione { get; set; }

        /*
         * CREATE TABLE IF NOT EXISTS nodi (
         *  idnodo int primary key autoincrement,
         *  nome text,
         *  descrizione text,
         *  lat float DEFAULT 0.0,
         *  lon float DEFAULT 0.0
         * ); 
         */

        public Nodo(int id, string nome, string descrizione, float x, float y)
        {
            IdNodo = id;
            Nome = nome;
            Descrizione = descrizione;
            Y = y;
            X = x;
            Creazione = DateTime.Now;
        }

        public float Distanza(Nodo target)
        {
            // TODO: cacolo della distanza
            float dx = Math.Abs( this.X - target.X );
            float dy = Math.Abs( this.Y - target.Y );
            return (float)Math.Sqrt( dx * dx + dy * dy );
        }
    }
}
