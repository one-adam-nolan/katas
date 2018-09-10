using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Katas.StringCalculator
{
    public class Calculator
    {
        public string Add(string numbers)
        {
            return SumAll(Break(numbers)).ToString();
        }

        private long GetNumberFromString(string number) => int.TryParse(number, out var result) ? result : 0;

        private string[] Break(string numbers)
        {
            var defaultSplit = numbers.Split(';');
            var filter = new List<string>();
            foreach (var item in defaultSplit)
            {
                filter.AddRange(item.Split(',', '\n'));
            }

            return filter.ToArray();
        }




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
