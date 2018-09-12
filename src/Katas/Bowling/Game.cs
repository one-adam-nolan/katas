﻿using System;
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
            //for (int i = 0; i < _rolls.Length; ++i)
            //score += _rolls[i];
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsSpare(frameIndex))
                    score += 10 + _rolls[frameIndex + 2];
                else
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                frameIndex += 2;
            }
            return score;
        }

        private bool IsSpare(int frameIndex) => _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;

    }
}
