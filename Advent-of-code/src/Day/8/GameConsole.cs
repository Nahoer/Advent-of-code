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


        public int GetLoopLine(string[] script)
        {
            this.Accumulator = 0;
            Boolean end = false;
            
            
            int indexLine = 0;
            List<int> markedLine = new List<int>();
            while (!end)
            {
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
                        }
                        else
                        {
                            next = true;
                        }
                        
                    }
                    else
                    {
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
                if (next)
                {
                    indexLine++;
                }

                if (script.Length.Equals(indexLine))
                {
                    end = true;
                    indexLine = -1;
                }

            }

            return indexLine;

        }

        public string[] FixLoop(string[] script)
        {
            string[] scriptCopy = (string[])script.Clone();
            int i = 0;
            while (this.GetLoopLine(scriptCopy)!=-1)
            {
                scriptCopy = (string[])script.Clone();
                string[] words = scriptCopy[i].Split(" ");
                if (words[0].Equals("jmp"))
                {
                    scriptCopy[i] = scriptCopy[i].Replace("jmp", "nop");

                }
                else if (words[0].Equals("nop"))
                {
                    scriptCopy[i] = scriptCopy[i].Replace("nop", "jmp");
                }

                i++;
            }

            return scriptCopy;
        }

    }
}
