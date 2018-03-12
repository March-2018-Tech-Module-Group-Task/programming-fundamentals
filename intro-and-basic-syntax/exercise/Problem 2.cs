using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve from the Console the width of the rectangle.
            //We recieve from the Console the height of the rectangle.
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //We calculate the area of the rectangle.
            double area = width*height;

            //We print the final result.
            Console.WriteLine(area);


        }
    }
}
