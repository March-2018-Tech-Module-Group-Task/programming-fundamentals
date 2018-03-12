using System;

namespace ProgramTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declairs first num//
            int first = int.Parse(Console.REadLine());
            //declairs second num//
            int second = int.Parse(Console.REadLine());
            //declairs third num//
            int third = int.Parse(Console.REadLine());
            //declairs fourth num//
            int fourth = int.Parse(Console.REadLine());
            //output of all numbers in four digit debit card format//
            Console.WriteLine($"{first:D2}{second:D2}{ third:D2}{fourth:D2}");
        }
    }
}
