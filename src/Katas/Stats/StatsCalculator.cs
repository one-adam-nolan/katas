using System;
namespace Katas.Stats
{
    public class StatsCalculator
    {
        private int[] _numbers { get; set; }

        public StatsCalculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public int MinNumber()
        {
            return LoopNumbersFor(Math.Min);
        }

        public int MaxNumber()
        {
            return LoopNumbersFor(Math.Max);
        }

        public double Average()
        {
            return CalculateAverage();
        }

        public int NumberOfElements()
        {
            return _numbers.Length;
        }

        private int LoopNumbersFor(Func<int, int, int> numberFunction, int? startNumber = null)
        {
            var target = startNumber ?? _numbers[0];
            for (var i = 0; i < _numbers.Length; ++i)
                target = numberFunction(target, _numbers[i]);
            return target;
        }

        private double CalculateAverage() => SumAllNumbers() / _numbers.Length;

        private double SumAllNumbers() => LoopNumbersFor(AddNumbers, 0);

        private int AddNumbers(int x, int y) => x + y;
    }
}
