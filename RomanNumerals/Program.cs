using System;
using RomanNumerals.SpecificNumeralGeneration;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeralGenerator generator = new RomanNumeralGenerator();
            generator.Generate(21);
            Console.WriteLine(generator.Generate(21));
        }
    }
}
