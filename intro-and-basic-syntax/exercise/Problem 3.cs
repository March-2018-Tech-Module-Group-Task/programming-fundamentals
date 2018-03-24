using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading miles
            int TheNum = int.Parse(Console.ReadLine());
            //Converting miles to kilometers
            Console.WriteLine($"{(TheNum * 1.60934):f2}");
        }
    }
}
