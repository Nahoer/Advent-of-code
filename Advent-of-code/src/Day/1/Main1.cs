using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_of_code.src.Day._1
{
    public class Main1
    {
        public static void Start()
        {
            
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\input\input1.txt"));

            //part 1
            int i = 0;
            int j = 0;
            int fig1 = 0;
            int fig2 = 0;
            while (i < lines.Length)
            {
                j = 0;
                while (j < lines.Length)
                {
                    int sum = Convert.ToInt32(lines[i]) + Convert.ToInt32(lines[j]);
                    if (sum == 2020)
                    {
                        fig1 = Convert.ToInt32(lines[i]);
                        fig2 = Convert.ToInt32(lines[j]);
                    }
                    j++;
                }
                i++;
            }

            Console.WriteLine(fig1 + "|" + fig2);
            Console.WriteLine(fig1 * fig2);

            //part 2
            int k = 0;
            i = 0;
            int fig3 = 0;
            while (i < lines.Length)
            {
                j = 0;
                while (j < lines.Length)
                {

                    k = 0;
                    while (k < lines.Length)
                    {
                        int sum = Convert.ToInt32(lines[i]) + Convert.ToInt32(lines[j]) + Convert.ToInt32(lines[k]);
                        if (sum == 2020)
                        {
                            fig1 = Convert.ToInt32(lines[i]);
                            fig2 = Convert.ToInt32(lines[j]);
                            fig3 = Convert.ToInt32(lines[k]);
                        }
                        k++;
                    }
                    
                    j++;
                }
                i++;
            }
            Console.WriteLine(fig1 + "|" + fig2+"|"+fig3);
            Console.WriteLine(fig1 * fig2 * fig3);

        }
    }
}
