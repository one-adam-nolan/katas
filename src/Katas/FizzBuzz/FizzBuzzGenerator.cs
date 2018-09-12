using System;
using System.Linq;

namespace Katas.FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public int[] GetNumberList() => Enumerable.Range(1, 100).ToArray();

        public string[] FizzAndBuzz(int[] numbers)
        {
            var numberList = numbers.ToList();
            return numberList.Select(ConvertToString).ToArray();
        }

        public string GetResultFor(int number)
        {
            var result = ConvertToString(number);
            return String.IsNullOrEmpty(result) ? number.ToString() : result;
        }

        private string ConvertToString(int num)
        {
            ThrowExceptionOutsideOfOneAndOneHundred(num);
            var output = "";
            if (IsDivisibleByThree(num))
                output += "fizz";
            if (IsDivisibleByFive(num))
                output += "buzz";

            return string.IsNullOrEmpty(output) ? num.ToString() : output;
        }

        private void ThrowExceptionOutsideOfOneAndOneHundred(int number)
        {
            if (IsLessThanOne(number) || IsGreaterThanOneHundred(number))
                throw new Exception($"{number} is not valid.  Numbers must be between 1 and 100");
        }

        private bool IsDivisibleByThree(int num) => num % 3 == 0;
        private bool IsDivisibleByFive(int num) => num % 5 == 0;
        private bool IsLessThanOne(int num) => num < 1;
        private bool IsGreaterThanOneHundred(int num) => num > 100;
    }
}
