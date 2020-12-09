using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_of_code.src.Day._3
{
    public class Main3
    {
        public static void Start()
        {
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\input\input3.txt"));

            int height = lines.Length;
            string[] words = lines[0].Split(" ");

            int width = words[0].Length;
            Container[,] content = new Container[width,height];
            int i = 0;
            int j = 0;
            foreach(string line in lines)
            {
                j = 0;
                string[] word = line.Split(" ");
                foreach(char c in word[0])
                {
                    
                    if (c.Equals('#'))
                    {
                        content[j,i] = new Container(Type.Tree);
                    }
                    else
                    {
                        content[j,i] = new Container(Type.Square);
                    }
                    j++;
                }

                i++;
            }

            //Part1
            Map map = new Map(content, height, width);
            Dictionary<Type, int> count = map.Cross(new Coords(0, 0), new Coords(3, 1));
            Console.WriteLine(count[Type.Tree]);

            //Part 2
            Dictionary<Type, int> count1 = map.Cross(new Coords(0, 0), new Coords(1, 1));
            Dictionary<Type, int> count2 = map.Cross(new Coords(0, 0), new Coords(3, 1));
            Dictionary<Type, int> count3 = map.Cross(new Coords(0, 0), new Coords(5, 1));
            Dictionary<Type, int> count4 = map.Cross(new Coords(0, 0), new Coords(7, 1));
            Dictionary<Type, int> count5 = map.Cross(new Coords(0, 0), new Coords(1, 2));
            Console.WriteLine(count1[Type.Tree]*count2[Type.Tree] * count3[Type.Tree] * count4[Type.Tree] * count5[Type.Tree]);
        }
    }
}
