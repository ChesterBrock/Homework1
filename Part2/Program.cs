/// Chapter No. 1		Exercise No. 2
/// File Name: MyFirstProgram.java
/// @author: Chester Brock 
/// Date:  August 24, 2021
///
/// Problem Statement:  displays a simple picture of your choice. It could be a car, 
/// a house, a flower, a tree, a square, a 3-D box, a star or other shapes.
/// 
/// 
/// Overall Plan:
/// 1) Think of a shape that will be displayed to the console
/// 2) Use a series of writeLine statements to create the image
/// 3) Use ReadLine statement to pause the display. 
/// 
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\\****__              ____             ");
            Console.WriteLine("  |    *****\\_      --/ *\\-__         ");
            Console.WriteLine("  /_          (_    ./ ,/----'          ");
            Console.WriteLine("    \\__         (_./  /              ");
            Console.WriteLine("       \\__           \\___----^__      ");
            Console.WriteLine("        _/   _                  \\    ");
            Console.WriteLine(" |    _/  __/ )\\\"\\ _____         *\\  ");
            Console.WriteLine(" |\\__/   /    ^ ^       \\____      ) ");
            Console.WriteLine("  \\___--\"                    \\_____)");
            Console.WriteLine("                                  \"\\");

            Console.ReadLine();
        }
    }
}
