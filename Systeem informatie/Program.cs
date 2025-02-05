namespace Systeem_informatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserName = Environment.UserName;
            string MachineName = Environment.MachineName;
            int ProcessorCount = Environment.ProcessorCount;
            bool is64OperatingSystem = Environment.Is64BitOperatingSystem;
            double WorkingSet = Environment.WorkingSet;
            double WorkingSetMB = Math.Round(WorkingSet / 1000000 , 2);
            double WorkingSetGB = Math.Round(WorkingSet / 1000000000 , 2);

            Console.WriteLine($"Systeeminformatie voor {UserName} op {MachineName}:\r\n---------------------------------------------------\r\n    Aantal processors: {ProcessorCount}\r\n    64-bit besturingssysteem: {is64OperatingSystem}\r\n    Huidige geheugengebruik: {WorkingSetMB} MB ({WorkingSetGB} GB)\r\n---------------------------------------------------");
        }
    }
}
