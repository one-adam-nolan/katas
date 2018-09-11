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

        private string ConvertToString(int num)
        {
            var output = "";

            if (IsDivisibleByThree(num))
                output += "fizz";
            if (IsDivisibleByFive(num))
                output += "buzz";

            return string.IsNullOrEmpty(output) ? num.ToString() : output;
        }

        private bool IsDivisibleByThree(int num) => num % 3 == 0;
        private bool IsDivisibleByFive(int num) => num % 5 == 0;
    }
}
