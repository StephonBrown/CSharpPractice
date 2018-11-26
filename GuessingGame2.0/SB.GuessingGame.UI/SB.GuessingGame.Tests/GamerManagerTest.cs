using System;
using NUnit.Framework;
using GuessingGame.BLL;

namespace SB.GuessingGame.Tests
{
    [TestFixture]
    public class GamerManagerTests
    {
        [Test]
        public void InvalidGuessTest()
        {
            GameManager gm = new GameManager();
            gm.Start();

            GuessResult actual = gm.ProcessGuess(130);
            Assert.AreEqual(GuessResult.Invalid, actual);

        }
        [Test]
        public void HigherGuessTest()
        {
            GameManager gm = new GameManager();
            gm.Start(15);

            GuessResult actual = gm.ProcessGuess(10);
            Assert.AreEqual(GuessResult.Higher, actual);

        }

        [Test]
        public void LowerGuessTest()
        {
            GameManager gm = new GameManager();
            gm.Start(15);

            GuessResult actual = gm.ProcessGuess(19);
            Assert.AreEqual(GuessResult.Lower, actual);

        }
        [Test]
        public void VictoryGuessTest()
        {
            GameManager gm = new GameManager();
            gm.Start(15);

            GuessResult actual = gm.ProcessGuess(15);
            Assert.AreEqual(GuessResult.Victory, actual);

        }


    }
}
