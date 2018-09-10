using Katas.StringCalculator;
using NUnit.Framework;

namespace KataTest.StringCalculator
{
    [TestFixture]
    public class StringCalculatorTest
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Calculator_Should_Return_Zero_With_No_Parameters()
        {
            var result = _calculator.Add("");

            Assert.AreEqual(result, "0");
        }

        [Test]
        public void Calculator_Should_Return_Value_Of_Individual_Number()
        {
            var result = _calculator.Add("1");
            Assert.AreEqual(result, "1");

        }

        [Test]
        public void Calculator_Should_Return_Sum_Of_Two_Numbers()
        {
            var result = _calculator.Add("1, 2");

            Assert.AreEqual(result, "3");
        }
    }
}
