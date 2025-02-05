namespace Dertien_in_een_dozijn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int doosGrootte = 8;
            int aantalEieren = 124;

            Console.WriteLine("Hoeveel dozen heb je?:");
            int aantalDozen = Console.ReadLine();



            Console.WriteLine($"{aantalEieren} eieren passen in {aantalDozen} dozen van doosgrootte:{doosGrootte}. Daarbij zal je nog 4 eieren over hebben.");
        }
    }
}
