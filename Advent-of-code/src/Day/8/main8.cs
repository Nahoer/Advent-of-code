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
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\Day\8\input.txt"));
            GameConsole g = new GameConsole();
            Console.WriteLine(g.RunScript(lines, 0));
            
        }

    }
}
