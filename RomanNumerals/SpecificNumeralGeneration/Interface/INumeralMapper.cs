using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals.SpecificNumeralGeneration.Interface
{
    interface INumeralMapper
    {
        public List<string> SpecificNumerals { get; }
        public List<int> Numerals { get; }
    }
}
