﻿using System;
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
            int input = int.Parse(Console.ReadLine());
            //Converting miles to kilometers
            Console.WriteLine($"{(input * 1.60934):f2}");
        }
    }
}
