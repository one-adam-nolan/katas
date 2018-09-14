using System;
using System.Diagnostics;

namespace Katas.Bowling
{
    public class Game
    {

        private int[] _rolls = new int[21];
        private int _currentRoll = 0;

        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += 10 + StrikeBonus(frameIndex);
                    ++frameIndex;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }

        private bool IsSpare(int frameIndex) => _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;

        private bool IsStrike(int frameIndex) => _rolls[frameIndex] == 10;

        private int SumOfBallsInFrame(int frameIndex) => _rolls[frameIndex] + _rolls[frameIndex + 1];

        private int StrikeBonus(int frameIndex) => _rolls[frameIndex + 1] + _rolls[frameIndex + 2];

        private int SpareBonus(int frameIndex) => _rolls[frameIndex + 2];

    }
}
