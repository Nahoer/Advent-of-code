using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_of_code.src.Day._8
{
    public class Main8
    {
        public static void Start()
        {
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\input\input8.txt")); 
            GameConsole g = new GameConsole();

            //Part 1
            int line = g.GetLoopLine(lines);
            Console.WriteLine(line);

            //Part 2
            lines = g.FixLoop(lines);
            Console.WriteLine(g.Accumulator);
            
        }

    }
}
