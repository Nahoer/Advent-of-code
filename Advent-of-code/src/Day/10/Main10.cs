using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_of_code.src.Day._10
{
    public class Main10
    {
        public static void Start()
        {
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\input\input10test2.txt"));
            List<int> lineToInt = new List<int>();
            foreach(string line in lines)
            {
                lineToInt.Add(Convert.ToInt32(line));
            }
            
            lineToInt.Sort();
            List<Node> nodes = new List<Node>();
            foreach (int i in lineToInt)
            {
                nodes.Add(new Node(i));
            }
            for (int i=1; i < nodes.Count; i++)
            {
                nodes[i - 1].SetChild(nodes[i]);
            }
            //Part 1
            Dictionary<Difference, int> difference = nodes[0].GetTotalDifferences();

            //Part 2

            Console.WriteLine(nodes[0].GetNbrWays());

            Console.ReadLine();


        }
    }
}
