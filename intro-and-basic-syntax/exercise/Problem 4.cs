using System;

namespace E_04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy_content = int.Parse(Console.ReadLine());
            int sugar_content = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{1.0*energy_content*volume/100}kcal, " +
                $"{1.0*sugar_content*volume/100}g sugars");

        }
    }
}
