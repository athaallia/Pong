using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerSP : MonoBehaviour
{
    public Ball ball;
    public ComputerPaddle computerPaddle;
    public PlayerPaddle playerPaddle;

    private int playerScore;
    private int computerScore;

    public TextMeshProUGUI computerScoreText;
    public TextMeshProUGUI playerScoreText;


    public void PlayerScore()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();

        ResetRound();
    }

    public void ComputerScore()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();

        ResetRound();
    }

    private void ResetRound()
    {
        computerPaddle.ResetPosition();
        playerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

}
