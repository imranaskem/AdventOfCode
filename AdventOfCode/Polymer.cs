using System;
using System.Collections.Generic;
using System.Text;

namespace Day05
{
    class Polymer
    {
        private readonly string _startPolymer;        

        public Polymer(string data)
        {
            this._startPolymer = data;
        }

        public int CalculateReactions()
        {
            var polymer = this._startPolymer;

            var loop = true;

            while (loop)
            {
                loop = false;                          

                for (int i = 0; i < polymer.Length; i++)
                {
                    if (i != (polymer.Length - 1))
                    {
                        var unitA = new Unit(polymer[i]);
                        var unitB = new Unit(polymer[i + 1]);

                        var reacted = unitA.DoTheyReact(unitB);

                        if (reacted == true)
                        {
                            polymer = polymer.Remove(i, 2);
                            loop = true;
                        }
                    }
                    
                }                
            }
            return polymer.Length;
        }
    }
}
