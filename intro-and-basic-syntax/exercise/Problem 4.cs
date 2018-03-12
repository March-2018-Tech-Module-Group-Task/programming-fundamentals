using System;

namespace E_04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name of product//
            string name = Console.ReadLine();
            //Volume in integer//
            int volume = int.Parse(Console.ReadLine());
            //Energy content value input//
            int energy_content = int.Parse(Console.ReadLine());
            //Sugar content value input//
            int sugar_content = int.Parse(Console.ReadLine());
            //Output Volume with ml//
            Console.WriteLine($"{volume}ml {name}:");
            //Output in the certant format//
            Console.WriteLine($"{1.0*energy_content*volume/100}kcal, " +
                $"{1.0*sugar_content*volume/100}g sugars");

        }
    }
}
