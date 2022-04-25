using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using RomanNumerals.SpecificNumeralGeneration;
using System.Collections.Generic;
using System.IO;

namespace TestSpecificNumeral
{
    [TestClass]
    public class SpecificNumberGeneratorTest
    {
        [TestMethod]
        public void TestCreateRomanNumeral()
        {
            string fileName = @"C:\Users\Макс\source\repos\RomanNumerals\TestSpecificNumeral\Data\numeralToRomanData.txt";

            var lines = File.ReadLines(fileName);
            var numbers = new List<int>();
            var romanNumerals = new List<string>();

            foreach (var line in lines)
            {
                var splittedLine = line.Split(':');
                numbers.Add(int.Parse(splittedLine[0]));
                romanNumerals.Add(splittedLine[1].Replace(" ", ""));
            }

            RomanNumeralGenerator generator = new RomanNumeralGenerator();

            for (int i = 0; i < numbers.Count; i++)
            {
                var generatedRomanNumeral = generator.Generate(numbers[i]);
                Assert.IsTrue(generatedRomanNumeral.Equals(romanNumerals[i]));
            }
        }
    }
}
