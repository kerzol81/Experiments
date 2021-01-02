using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace read_and_write_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"emails.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            lines.Add("Cilse, cilse@gmail.com");
            lines.Add("Dean, dean@gmail.com");

            filePath = @"emailsmod.txt";

            File.WriteAllLines(filePath, lines);

            
        }
    }
}
