namespace Programma02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Saluto il mio utente, HELO
            Console.WriteLine("Benvenuto in Tabelline!");
            // gli pongo la mia domanda
            Console.Write("Mi dici che tabellina vuoi?");
            // predispongo una variabile dove conservare le informazioni
            string risposta = Console.ReadLine();
            // effettuo il parsing (od il casting) in formato numerico
            int numero = int.Parse(risposta);
            // ripeto per sapere quante moltiplicazioni fare
            Console.Write("E quante volte lo dovrei fare?");
            // leggo la sua risposta
            risposta = Console.ReadLine();
            int ripetizioni = int.Parse(risposta);
            // imposto un contatore
            int n = 0;
            // imposto un ciclo
            do
            {
                int risultato = numero * n;
                n = n + 1;
                Console.WriteLine(risultato);
            } while (n < ripetizioni);
            // che conclude solo quando la condizione non è più valida
        }
    }
}
