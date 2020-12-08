using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_of_code.Day._7
{
    public class Main7
    {
        public static void Start()
        {
            BagGraph bagGraph = new BagGraph();

            //Creation of nodes
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\Day\7\input.txt"));
            foreach (string line in lines)
            {
                string[] words = line.Split(" ");
                bagGraph.AddBag(words[0] + " " + words[1], new Bag(words[0] + " " + words[1]));

            }

            //Creation of links between nodes
            foreach (string line in lines)
            {
                string[] words = line.Split(" ");
                string name = words[0] + " " + words[1];
                int i = 0;
                foreach (string word in words)
                {

                    char[] w = word.ToCharArray();
                    char firstChar = w[0];
                    if (char.IsDigit(firstChar))
                    {
                        string nameToLink = words[i + 1] + " " + words[i + 2];
                        bagGraph.Bags[name].AddChild(bagGraph.Bags[nameToLink], Convert.ToInt32(new string(firstChar, 1)));
                    }
                    i++;
                }
            }

            //Part 1
            Console.WriteLine(bagGraph.CanContain("shiny gold").Count);

            //Part 2
            Console.WriteLine(bagGraph.Bags["shiny gold"].TotalWeightSum());
            
        }
    }
}
