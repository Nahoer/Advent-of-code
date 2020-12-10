using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_of_code.src.Day._4
{
    public class Main4
    {
        
        public static void Start()
        {
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\input\input4.txt"));
            List<string> passportLines = new List<string>();
            List<Passport> passports = new List<Passport>();
            for(int i=0; i<=lines.Length; i++)
            {
                if (i >= lines.Length||lines[i]=="")
                { 
                    passports.Add(new Passport(passportLines));
                    passportLines.Clear();
                }
                else
                {
                    passportLines.Add(lines[i]);

                }

            }
            int count = 0;
            foreach(Passport p in passports)
            {
                if (p.IsValid())
                {
                    count++;
                }
            }

            Console.WriteLine(count);
             

        }
    }
}
