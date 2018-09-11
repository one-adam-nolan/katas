using System;
using Katas.RomanNumeral;
using NUnit.Framework;

namespace KataTest.RomanNumeral
{
    [TestFixture]
    public class RomanNumeralConverterTest
    {
        private RomanNumeralConverter _converter;
        [SetUp]
        public void Setup()
        {
            _converter = RomanNumeralConverter.Create();

        }

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        public void Should_Return_Default_Values_For_Symbols(string symbol, int expected)
        {
            var result = _converter.Convert(symbol);

            Assert.AreEqual(result, expected);
        }

        [TestCase("IV", 4)]
        [TestCase("IIX", 8)]
        [TestCase("MMVI", 2006)]
        [TestCase("MCMXLIV", 1944)]
        public void Should_Add_Smaller_Values_On_The_Right(string symbols, int expected)
        {
            Assert.AreEqual(_converter.Convert(symbols), expected);

        }
    }
}
