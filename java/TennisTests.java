import org.junit.Assert;
import org.junit.Test;

public class TennisTests
{

    @Test
    public void TennisScoreTests()
    {
        assertTennisScore(0, 0, "Love-All");
        assertTennisScore(1, 1, "Fifteen-All");
        assertTennisScore(2, 2, "Thirty-All");
        assertTennisScore(3, 3, "Deuce");
        assertTennisScore(4, 4, "Deuce");
        assertTennisScore(1, 0, "Fifteen-Love");
        assertTennisScore(0, 1, "Love-Fifteen");
        assertTennisScore(2, 0, "Thirty-Love");
        assertTennisScore(0, 2, "Love-Thirty");
        assertTennisScore(3, 0, "Forty-Love");
        assertTennisScore(0, 3, "Love-Forty");
        assertTennisScore(4, 0, "Win for player1");
        assertTennisScore(0, 4, "Win for player2");
        assertTennisScore(2, 1, "Thirty-Fifteen");
        assertTennisScore(1, 2, "Fifteen-Thirty");
        assertTennisScore(3, 1, "Forty-Fifteen");
        assertTennisScore(1, 3, "Fifteen-Forty");
        assertTennisScore(4, 1, "Win for player1");
        assertTennisScore(1, 4, "Win for player2");
        assertTennisScore(3, 2, "Forty-Thirty");
        assertTennisScore(2, 3, "Thirty-Forty");
        assertTennisScore(4, 2, "Win for player1");
        assertTennisScore(2, 4, "Win for player2");
        assertTennisScore(4, 3, "Advantage player1");
        assertTennisScore(3, 4, "Advantage player2");
        assertTennisScore(5, 4, "Advantage player1");
        assertTennisScore(4, 5, "Advantage player2");
        assertTennisScore(15, 14, "Advantage player1");
        assertTennisScore(14, 15, "Advantage player2");
        assertTennisScore(6, 4, "Win for player1");
        assertTennisScore(4, 6, "Win for player2");
        assertTennisScore(16, 14, "Win for player1");
        assertTennisScore(14, 16, "Win for player2");
    }

    public void assertTennisScore(int player1Score, int player2Score, String expectedScore)
    {
        TennisGame game = new TennisGame("player1", "player2");
        int highestScore = Math.max(player1Score, player2Score);
        for (int i = 0; i < highestScore; i++)
        {
            if (i < player1Score)
                game.wonPoint("player1");
            if (i < player2Score)
                game.wonPoint("player2");
        }
        Assert.assertEquals(expectedScore, game.getScore());
    }
}

