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
            return LoopNumbersFor((newNum, prevNum) => prevNum < newNum);
        }

        public int MaxNumber()
        {
            throw new NotImplementedException();
        }

        public double Average()
        {
            throw new NotImplementedException();
        }

        public int NumberOfElements()
        {
            return _numbers.Length;
        }

        private int LoopNumbersFor(Func<int, int, bool> predicate)
        {
            var target = _numbers[0];
            for (var i = 0; i < _numbers.Length; ++i)
                target = predicate(_numbers[i], target) ? target : _numbers[i];
            return target;
        }
    }
}
