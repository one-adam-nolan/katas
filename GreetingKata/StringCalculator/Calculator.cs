using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Katas.StringCalculator
{
    public class Calculator
    {
        public string Add(string numbers)
        {
            return SumAll(Break(numbers)).ToString();
        }


        private string[] Break(string numbers)
        {
            var outterSplit = BreakOnSemiColon(numbers);
            return outterSplit.SelectMany(BreakOnCommaAndNewLine).ToArray();
        }

        private string[] BreakOnSemiColon(string numbers) => numbers.Split(';');
        private string[] BreakOnCommaAndNewLine(string numbers) => numbers.Split(',', '\n');
        private string[] BreakOnSemiColon(string[] numbersSet) => numbersSet.SelectMany(s => s.Split(',', '\n')).ToArray();
        private long GetNumberFromString(string number) => int.TryParse(number, out var result) ? result : 0;

        private void CheckForNegativeNumbers(IEnumerable<long> numbers)
        {
            var negatives = numbers.Where(num => num < 0);

            if (negatives.Any())
                throw new Exception($"Negative Numbers not Allowed! {string.Join(' ', negatives)}");
        }

        private long SumAll(string[] numbers)
        {
            var convertedNumbers = numbers.Select(GetNumberFromString);
            CheckForNegativeNumbers(convertedNumbers);

            return convertedNumbers.Sum();
        }


    }
}
