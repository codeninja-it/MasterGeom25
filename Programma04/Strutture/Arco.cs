using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programma04.Strutture
{
    public class Arco
    {
        public int da {  get; set; }
        public int a { get; set; }
        public float lunghezza { get; set; }

        public Arco(Nodo partenza, Nodo arrivo) {
            da = partenza.IdNodo;
            a = arrivo.IdNodo;
            lunghezza = partenza.Distanza(arrivo);
        }
    }
}
