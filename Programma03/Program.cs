namespace Programma03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string risposta;
            do
            {
                Funzioni.Tabellina();
                risposta = Funzioni.Chiedi("Ne vuoi un'altra?");
            } while (risposta == "si");       
        }
    }
}
