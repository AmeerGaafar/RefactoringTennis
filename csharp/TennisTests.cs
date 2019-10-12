using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis
{
    [TestClass]
    public class TennisTests
    {

        [TestMethod]
        public void TennisScoreTests()
        {
            AssertTennisScore(0, 0, "Love-All");
            AssertTennisScore(1, 1, "Fifteen-All");
            AssertTennisScore(2, 2, "Thirty-All");
            AssertTennisScore(3, 3, "Deuce");
            AssertTennisScore(4, 4, "Deuce");
            AssertTennisScore(1, 0, "Fifteen-Love");
            AssertTennisScore(0, 1, "Love-Fifteen");
            AssertTennisScore(2, 0, "Thirty-Love");
            AssertTennisScore(0, 2, "Love-Thirty");
            AssertTennisScore(3, 0, "Forty-Love");
            AssertTennisScore(0, 3, "Love-Forty");
            AssertTennisScore(4, 0, "Win for player1");
            AssertTennisScore(0, 4, "Win for player2");
            AssertTennisScore(2, 1, "Thirty-Fifteen");
            AssertTennisScore(1, 2, "Fifteen-Thirty");
            AssertTennisScore(3, 1, "Forty-Fifteen");
            AssertTennisScore(1, 3, "Fifteen-Forty");
            AssertTennisScore(4, 1, "Win for player1");
            AssertTennisScore(1, 4, "Win for player2");
            AssertTennisScore(3, 2, "Forty-Thirty");
            AssertTennisScore(2, 3, "Thirty-Forty");
            AssertTennisScore(4, 2, "Win for player1");
            AssertTennisScore(2, 4, "Win for player2");
            AssertTennisScore(4, 3, "Advantage player1");
            AssertTennisScore(3, 4, "Advantage player2");
            AssertTennisScore(5, 4, "Advantage player1");
            AssertTennisScore(4, 5, "Advantage player2");
            AssertTennisScore(15, 14, "Advantage player1");
            AssertTennisScore(14, 15, "Advantage player2");
            AssertTennisScore(6, 4, "Win for player1");
            AssertTennisScore(4, 6, "Win for player2");
            AssertTennisScore(16, 14, "Win for player1");
            AssertTennisScore(14, 16, "Win for player2");
        }

        public void AssertTennisScore(int player1Score, int player2Score, string expectedScore)
        {
            var game = new TennisGame("player1", "player2");
            var highestScore = Math.Max(player1Score, player2Score);
            for (var i = 0; i < highestScore; i++)
            {
                if (i < player1Score)
                    game.WonPoint("player1");
                if (i < player2Score)
                    game.WonPoint("player2");
            }
            Assert.AreEqual(expectedScore, game.GetScore());
        }
    }
}
