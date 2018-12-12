using System;
using System.Collections.Generic;
using System.Text;

namespace Day05
{
    class Unit
    {
        private enum Polarity
        {
            Upper,
            Lower
        }

        private readonly char _type;
        private readonly Polarity _polarity;

        public Unit(char type)
        {
            this._type = char.ToUpper(type);

            this._polarity = char.IsLower(type) ? Polarity.Lower : Polarity.Upper;
        }

        public bool DoTheyReact(Unit unit)
        {
            var typeMatch = this._type == unit._type;
            var polarityMatch = this._polarity != unit._polarity;

            if (typeMatch && polarityMatch)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            if (this._polarity == Polarity.Lower)
            {
                return this._type.ToString().ToLower();
            }
            else
            {
                return this._type.ToString();
            }
        }
    }
}
