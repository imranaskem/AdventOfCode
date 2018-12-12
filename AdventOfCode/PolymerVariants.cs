using System;
using System.Collections.Generic;
using System.Text;

namespace Day05
{
    class PolymerVariants
    {
        public HashSet<string> Polymers { get; private set; }

        public PolymerVariants(string data)
        {
            this.Polymers = new HashSet<string>();
            var letter = 'a';

            for (int i = 0; i < 26; i++)
            {
                var newPolymer = data.Replace(letter.ToString(), string.Empty);
                newPolymer = newPolymer.Replace(letter.ToString().ToUpper(), string.Empty);

                this.Polymers.Add(newPolymer);

                letter++;
            }
        }
    }
}
