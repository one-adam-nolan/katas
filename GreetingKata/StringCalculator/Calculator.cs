using System;
using System.Collections.Generic;

namespace Katas.StringCalculator
{
    public class Calculator
    {
        public string Add(string numbers)
        {
            return SumAll(BreakOnCommas(numbers)).ToString();
        }

        private long GetNumberFromString(string number) => String.IsNullOrEmpty(number) ? 0 : int.Parse(number);

        private string[] BreakOnCommas(string numbers) => numbers.Split(",");

        private long SumAll(string[] numbers)
        {
            long sum = 0;

            foreach (var number in numbers)
            {
                sum += GetNumberFromString(number);
            }
            return sum;
        }


    }
}
