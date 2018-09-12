using System;
using System.Diagnostics;
using System.Linq;
using Katas.FizzBuzz;
using NUnit.Framework;

namespace KataTest.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzzGenerator _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzzGenerator();
        }

        [Test]
        public void Should_Return_Numbers_One_To_One_Hundred()
        {
            int[] result = _fizzBuzz.GetNumberList();

            var isSorted = true;

            for (var i = 0; i < result.Length; ++i)
            {
                if (i + 1 < result.Length && result[i + 1] != result[i] + 1)
                    isSorted = false;
            }

            Assert.IsTrue(isSorted);
            Assert.AreEqual(result, Enumerable.Range(1, 100).ToArray());
            Assert.AreEqual(result.First(), 1);
            Assert.AreEqual(result.Last(), 100);
        }

        [Test]
        public void Should_Convert_To_String_Printing_Fizz_And_Buzz()
        {
            var numbers = _fizzBuzz.GetNumberList();
            var result = _fizzBuzz.FizzAndBuzz(numbers);

            Assert.IsFalse(result.Any(n => int.TryParse(n, out int i) && i % 3 == 0));
            Assert.IsFalse(result.Any(n => int.TryParse(n, out int i) && i % 5 == 0));
        }

        [Test]
        [TestCase(1, "1")]
        [TestCase(3, "fizz")]
        [TestCase(5, "buzz")]
        [TestCase(30, "fizzbuzz")]
        public void Should_Return_Result_For_Individual_Number(int number, string expectedResult)
        {
            var result = _fizzBuzz.GetResultFor(number);

            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase(0)]
        [TestCase(101)]
        public void Should_Throw_Exception_For_Numbers_Above_Or_Below_One_Throw_One_Hundred(int number)
        {
            Assert.Throws<Exception>(() => _fizzBuzz.GetResultFor(number));
        }
    }
}
