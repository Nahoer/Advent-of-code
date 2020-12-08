using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Advent_of_code.src.Day._2
{
    public class Main2
    {
        public static void Start()
        {
            List<Password> passwords = new List<Password>();
            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory().Replace(@"bin\Debug\netcoreapp3.1", @"src\input\input2.txt"));
            foreach(string line in lines)
            {
                string[] words = line.Split(" ");
                string[] extremum = words[0].Split("-");
                Password password = new Password(words[2]);
                password.SetPolicy(words[1].ToCharArray()[0], Convert.ToInt32(extremum[0]), Convert.ToInt32(extremum[1]));
                passwords.Add(password);
            }

            int count = 0;
            foreach(Password password in passwords)
            {
                if (password.IsValid())
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
