#include <string.h>

char* tennis_score(int p1Score, int p2Score,char * score) {
    score[0] = '\0';
    int tempScore=0;
    if (p1Score==p2Score)
    {
        switch (p1Score)
        {
            case 0:
                    strcat(score, "Love-All");
                break;
            case 1:
                    strcat(score,"Fifteen-All");
                break;
            case 2:
                    strcat(score,"Thirty-All");
                break;
            default:
                    strcat(score,"Deuce");
                break;
            
        }
    }
    else if (p1Score>=4 || p2Score>=4)
    {
        int minusResult = p1Score-p2Score;
        if (minusResult==1) strcat(score,"Advantage player1");
        else if (minusResult ==-1) strcat(score,"Advantage player2");
        else if (minusResult>=2) strcat(score,"Win for player1");
        else strcat(score,"Win for player2");
    }
    else
    {
        for (int i=1; i<3; i++)
        {
            if (i==1) tempScore = p1Score;
            else { strcat(score,"-"); tempScore = p2Score;}
            switch(tempScore)
            {
                case 0:
                    strcat(score,"Love");
                    break;
                case 1:
                    strcat(score,"Fifteen");
                    break;
                case 2:
                    strcat(score,"Thirty");
                    break;
                case 3:
                    strcat(score,"Forty");
                    break;
            }
        }
    }
    return score;
}