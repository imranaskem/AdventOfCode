using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Utils;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            var data = FileHandler.LoadLineFromFile(args[0]);

            var polymers = new PolymerVariants(data);

            var results = new HashSet<int>();

            foreach (var line in polymers.Polymers)
            {
                var poly = new Polymer(line);

                var resultLength = poly.CalculateReactions();

                results.Add(resultLength);
            }

            var result = results.Min();

            Console.WriteLine(result);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadLine();
        }
    }
}
