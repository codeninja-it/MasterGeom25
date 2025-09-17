namespace Programma03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // chiedo quale tabellina
            Console.Write("Quale tabellina vuoi? ");
            int numero = int.Parse( Console.ReadLine() );
            // ne chiedo anche la lunghezza
            Console.Write("Per quante volte ripeto?");
            int ripetizioni = int.Parse( Console.ReadLine() );
            // chiedo dove scaricare i dati
            Console.Write("Come chiamo il file?");
            string nomeFile = Console.ReadLine();
            // inizializzo un buffer vuoto
            string buffer = "";
            // eseguo il mio ciclo
            for (int n = 0; n < ripetizioni; n = n + 1)
            {
                int risultato = numero * n;
                //Console.WriteLine(numero + " X " + n + " = " + risultato);
                //Console.WriteLine($"{numero} X {n} = {risultato}");
                buffer = buffer + $"{numero} X {n} = {risultato}\n";
            }
            // scarico i dati su disco
            File.WriteAllText(nomeFile, buffer);
        }
    }
}
