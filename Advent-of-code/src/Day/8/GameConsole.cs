using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._8
{
    public class GameConsole
    {


        public GameConsole()
        {
        }


        public int RunScript(string[] script, int line)
        {
            int accumulator = 0;
            Boolean isPositive = false;
            string[] arguments = script[line].Split(" ");
            if (arguments[1].ToCharArray()[0].Equals('+'))
            {
                isPositive = true;
            }
            string argument1 = arguments[1].Remove('+');
            argument1 = argument1.Remove('-');
            int digit = Convert.ToInt32(argument1.Remove('+')); 
            if (arguments[0].Equals("acc"))
            {
                if(isPositive)
                {

                    accumulator += digit;
                }
                else
                {
                    accumulator -= digit;
                }
            }
            else if (arguments[0].Equals("jmp"))
            {
                if (isPositive)
                {
                    accumulator += RunScript(script, line + digit);
                }
                else
                {
                    accumulator -= RunScript(script, line - digit);
                }
            }
            else
            {
                if (script.Length > line + 1)
                {
                    accumulator += RunScript(script, line + 1);
                }                
            }

            return accumulator;
        }

    }
}
