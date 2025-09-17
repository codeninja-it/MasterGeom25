using Programma04.Strutture;

namespace Programma04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nodo milano = new Nodo();
            milano.IdNodo = 0;
            milano.Nome = "Milano";
            milano.Descrizione = "Città della Lombardia";
            milano.Lat = 45.46f;
            milano.Long = 9.18f;

            Nodo[] mappa = new Nodo[] { milano };

            Console.WriteLine("Hello, World!");
        }
    }
}
