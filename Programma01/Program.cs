namespace Programma01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creo le variabili in un formato numerico a 32bit
            int a = 5;
            int b = 5;
            int c = a * b;
            float lat = 43.345f;
            float lon = 11.1123f;
            float numeroacaso = lat * lon;
            // scrivo all'utente il risultato
            System.Console.Write(a);
            System.Console.Write(" * ");
            System.Console.Write(b);
            System.Console.Write(" = ");
            System.Console.Write(c);
        }
    }
}
