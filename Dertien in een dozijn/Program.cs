namespace Dertien_in_een_dozijn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een naam:");
            string woord1 = Console.ReadLine();
            Console.WriteLine("Geef een zelfstandig naamwoord:");
            string woord2 = Console.ReadLine();
            Console.WriteLine("Geef een adjectief:");
            string woord3 = Console.ReadLine();
            Console.WriteLine("Geef een werkwoord:");
            string woord4 = Console.ReadLine();

            Console.WriteLine("\nHier komt het!");

            Console.WriteLine($"Op een dag ging {woord1} naar de AP Hogeschool. Hij zag daar een {woord3} {woord2} en vond dat zo grappig dat hij begon te {woord4}.");
        }
    }
}
