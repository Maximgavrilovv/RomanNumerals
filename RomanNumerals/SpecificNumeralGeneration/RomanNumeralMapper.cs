using System;
using System.Collections.Generic;
using System.Text;
using RomanNumerals.SpecificNumeralGeneration.Interface;

namespace RomanNumerals.SpecificNumeralGeneration
{
    class RomanNumeralMapper : INumeralMapper
    {
        public List<string> SpecificNumerals => new List<string>() 
        {
            "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" 
        };

        public List<int> Numerals => new List<int>() 
        { 
            1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 
        };
    }
}
