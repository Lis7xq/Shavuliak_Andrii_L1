using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();
            Names.Add("Alan");
            Names.Add("Zack");
            Names.Add("Nick");
            Names.Add("Andrew");

            int i = 0;
            Names = Names.Select(s => i++ % 2 != 0 ?
            string.Join("", s.Reverse()) :
            s).ToList();
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }

        }

    }
}
