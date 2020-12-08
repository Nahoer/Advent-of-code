using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._8
{
    public class GameConsole
    {

        public int Accumulator { get; private set; } 
        public GameConsole()
        {
            this.Accumulator = 0;
        }


        public int RunScript(string[] script)
        {
            Boolean end = false;
            
            int indexLine = 0;
            List<int> markedLine = new List<int>();
            while (!end)
            {
                Console.Write("Line " + indexLine);
                Console.WriteLine(" | "+script[indexLine]);
                Boolean next = false;
                markedLine.Add(indexLine);
                string line = script[indexLine];
                string[] argument = line.Split(" ");
                int digit = Convert.ToInt32(argument[1].Remove(0, 1));
                if (argument[1].ToCharArray()[0].Equals('-'))
                {
                    digit*=-1;
                }


                if (argument[0].Equals("jmp"))
                {
                    if (!markedLine.Contains(indexLine + digit))
                    {
                        if (indexLine+digit < script.Length)
                        {
                            indexLine += digit;
                            Console.WriteLine("   jump to " + indexLine);
                        }
                        else
                        {
                            next = true;
                            Console.WriteLine("    "+(indexLine+1) + " is too high, skip");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("    line already read--------------");
                        end = true;
                    }
                    
                }
                else
                {
                    if (argument[0].Equals("acc"))
                    {
                        this.Accumulator += digit;
                    }
                    next = true; ;
                }
                Console.WriteLine("   Accumlateur: " + this.Accumulator);
                if (next)
                {
                    Console.WriteLine("   next line");
                    indexLine++;
                }
            }
            return this.Accumulator;
        }

    }
}
