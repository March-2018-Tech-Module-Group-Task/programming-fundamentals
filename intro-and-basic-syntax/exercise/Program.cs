using System;

namespace ProgramTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();

            int productVolume = int.Parse(Console.ReadLine());
            int productEnergy = int.Parse(Console.ReadLine());
            int productSugar = int.Parse(Console.ReadLine());

            double energy = productVolume / 100.00 * productEnergy;
            double sugars = productVolume / 100.00 * productSugar;

            Console.WriteLine($"{productVolume}ml {productName}:");
            Console.WriteLine($"{energy}kcal, {sugars}g sugars");

        }
    }
}
