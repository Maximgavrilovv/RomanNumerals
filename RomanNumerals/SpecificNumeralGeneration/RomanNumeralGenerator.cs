using System;
using System.Collections.Generic;
using System.Text;
using RomanNumerals.SpecificNumeralGeneration.Interface;

namespace RomanNumerals.SpecificNumeralGeneration
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        private INumeralMapper Mapper;
        public int MaxNumber { get; set; }

        public RomanNumeralGenerator(int number = 3999)
        {
            MaxNumber = number;
            Mapper = new RomanNumeralMapper();
        }

        public string Generate(int number)
        {
            if (number < 1 || number > MaxNumber) return "Please enter int value from 1 to 3999";

            var romanNumeral = string.Empty;

            while (number > 0)
            {
                // find biggest numeral that is less than equal to number
                var index = Mapper.Numerals.FindIndex(x => x <= number);
                // subtract it's value from your number
                number -= Mapper.Numerals[index];
                // tack it onto the end of your roman numeral
                romanNumeral += Mapper.SpecificNumerals[index];
            }

            return romanNumeral;
        }
    }
}
