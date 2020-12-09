using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_of_code.src.Day._9
{
    public class Main9
    {
        public static void Start()
        {
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\input\input9.txt"));
            List<ulong> sequence = new List<ulong>();
            foreach (string line in lines)
            {
                sequence.Add(Convert.ToUInt64(line));
            }

            //Part 1
            Xmas xmas = new Xmas(sequence, 25);
            Console.WriteLine(xmas.IsConform(xmas.PreambleSize));

            //Part 2
            List<int> range = xmas.GetRangeOf(xmas.IsConform(xmas.PreambleSize));
            Console.WriteLine(xmas.GetMaxRange(range[0], range[1]) + xmas.GetMinRange(range[0], range[1]));

        }
    }
}
