using System;
using Katas.Bowling;
using NUnit.Framework;

namespace KataTest.Bowling
{
    public class GameTest
    {
        private Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        public void Should_Score_Zero_On_All_Gutters()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, _game.Score());
        }

        [Test]
        public void Should_Score_Twenty_On_All_Ones()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, _game.Score());
        }

        [Test]
        public void Should_Account_For_One_Spare()
        {
            RollSpare();
            _game.Roll(3);
            RollMany(17, 0);

            Assert.AreEqual(16, _game.Score());
        }

        [Test]
        public void Should_Account_For_One_Strike()
        {
            _game.Roll(10);
            _game.Roll(3);
            _game.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, _game.Score());
        }

        [Test]
        public void Should_Score_Perfect_Game()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, _game.Score());
        }


        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; ++i)
                _game.Roll(pins);
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
        }

        private void RollStrike()
        {
            _game.Roll(10);
        }

    }
}
