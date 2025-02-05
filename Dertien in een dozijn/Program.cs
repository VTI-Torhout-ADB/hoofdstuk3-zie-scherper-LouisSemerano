namespace Dertien_in_een_dozijn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int doosGrootte = 8;
            double aantalEieren = 124;

            Console.WriteLine("Hoeveel dozen heb je?:");
            double aantalDozen = Console.ReadLine();

            double overigeEieren = aantalEieren % aantalDozen;


            Console.WriteLine($"{aantalEieren} eieren passen in {aantalDozen} dozen van doosgrootte:{doosGrootte}. Daarbij zal je nog {overigeEieren} eieren over hebben.");
        }
    }
}
