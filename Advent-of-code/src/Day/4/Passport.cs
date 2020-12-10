using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_code.src.Day._4
{
    
    public class Passport
    {
        public string Byr { get; private set; }
        public string Iyr { get; private set; }
        public string Eyr { get; private set; }
        public string Hgt { get; private set; }
        public string Hcl { get; private set; }
        public string Ecl { get; private set; }
        public string Pid { get; private set; }
        public string Cid { get; private set; }

        public Passport(List<string> lines)
        {
            foreach(string line in lines)
            {
                foreach(string argument in line.Split(" "))
                {
                    string[] words = argument.Split(":");
                    switch (words[0])
                    {
                        case "byr":
                            this.Byr = words[1];
                            break;
                        case "iyr":
                            this.Iyr = words[1];
                            break;
                        case "eyr":
                            this.Eyr = words[1];
                            break;
                        case "hgt":
                            this.Hgt = words[1];
                            break;
                        case "hcl":
                            this.Hcl = words[1];
                            break;                           
                        case "ecl":
                            this.Ecl = words[1];
                            break;
                        case "pid":
                            this.Pid = words[1];
                            break;
                        case "cid":
                            this.Cid = words[1];
                            break;
                    }

                }
            }
        }

        public Boolean IsValid()
        {
            return (this.Byr != null) && (this.Iyr != null) && (this.Eyr != null) && (this.Hgt != null) && (this.Hcl != null) && (this.Ecl != null) && (this.Pid != null);
        }
    }
}
