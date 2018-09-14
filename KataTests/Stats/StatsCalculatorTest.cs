using System;
using System.Linq;
using Katas.Stats;
using NUnit.Framework;

namespace KataTest.Stats
{
    /*
     * Your task is to process a sequence of integer numbers 
     * to determine the following statistics:
     * o) minimum value
     * o) maximum value
     * o) number of elements in the sequence
     * o) average value
     * 
     * For example: [6, 9, 15, -2, 92, 11]
     * o) minimum value = -2
     * o) maximum value = 92
     * o) number of elements in the sequence = 6
     * o) average value = 18.166666
     */

    public class StatsCalculatorTest
    {
        private StatsCalculator _calculator;
        private int[] _numberSet = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [SetUp]
        public void Setup()
        {
            _calculator = new StatsCalculator(_numberSet);
        }

        [Test]
        public void Should_Return_Minimum_Number()
        {
            int result = _calculator.MinNumber();
            AssertAreEqual(result, _numberSet.ToList().Min());
        }

        [Test]
        public void Should_Return_Maximum_Number()
        {
            int result = _calculator.MaxNumber();
            AssertAreEqual(result, _numberSet.ToList().Max());
        }

        [Test]
        public void Should_Return_Average_Number()
        {
            double result = _calculator.Average();
            AssertAreEqual(result, _numberSet.ToList().Average());
        }

        [Test]
        public void Should_Return_Number_Of_Elements()
        {
            int result = _calculator.NumberOfElements();
            AssertAreEqual(result, _numberSet.ToList().Count());
        }

        private void AssertAreEqual(object expected, object actual)
        {
            Assert.AreEqual(actual, expected);
        }
    }
}
