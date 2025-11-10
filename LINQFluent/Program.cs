using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace LINQFluent
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] book = File.ReadAllLines("test.txt");

            int linesMoreThan30 = book.Count(s => s.Length > 30);

            Console.WriteLine($"Lines with more than 30 chars: {linesMoreThan30}");


            double avgLineRead = book
                //.Select(s => s.Length)
                .Average(s => s.Length);

            Console.WriteLine($"Line size average: {avgLineRead}");


            bool anyLargerThan120 = book.Any(s => s.Length > 120);

            Console.WriteLine($"Exist > 120? {anyLargerThan120}");


            IEnumerable<string> wordY = book
                .Where(s => s.Contains("Y"))
                .Select(s => s.Trim().Split()[0].ToUpper());

            foreach (string word in wordY)
            {
                Console.WriteLine(word);
            }
        }
    }
}
