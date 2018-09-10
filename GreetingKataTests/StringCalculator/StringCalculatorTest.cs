using Katas.StringCalculator;
using NUnit.Framework;

namespace KataTest.StringCalculator
{

    /// <summary>
    /// Here is the Article for this Kata
    /// http://osherove.com/tdd-kata-1/
    /// </summary>
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
        public void Should_Return_Zero_With_No_Parameters()
        {
            var result = _calculator.Add("");
            Assert.AreEqual(result, "0");
        }

        [Test]
        public void Should_Return_Value_Of_Individual_Number()
        {
            var result = _calculator.Add("1");
            Assert.AreEqual(result, "1");
        }

        [Test]
        public void Should_Return_Sum_Of_Two_Numbers()
        {
            var result = _calculator.Add("1, 2");
            Assert.AreEqual(result, "3");
        }

        [Test]
        public void Should_Allow_Line_Breaks_For_Separator()
        {
            var result = _calculator.Add("1,2\n3");
            Assert.AreEqual(result, "6");
        }

        [Test]
        public void Should_Use_Semi_Colon_As_Separator()
        {
            var result = _calculator.Add("//;\n1;2");

            Assert.AreEqual(result, "3");
        }
    }
}
