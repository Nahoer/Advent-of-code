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
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\input\input3test.txt"));

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

            Map map = new Map(content, height, width);

            Dictionary<Type, int> count = map.Cross(new Coords(0, 0), new Coords(3, 1));
            Console.WriteLine(count[Type.Tree]);
            Console.WriteLine(map.ToString());
        }
    }
}
