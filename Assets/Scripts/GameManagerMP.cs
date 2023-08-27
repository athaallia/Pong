using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManagerMP : MonoBehaviour
{
    public Ball ball;
    public PlayerPaddle playerPaddle;

    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    private int player1Score;
    private int player2Score;

    public void Player1Score()
    {
        if (playerPaddle.isPlayer1)
        {
            player1Score++;
            player1ScoreText.text = player1Score.ToString();

            ResetRound();
        }
    }

    public void Player2Score()
    {
        if (playerPaddle)
        {
            player2Score++;
            player2ScoreText.text = player2Score.ToString();

            ResetRound();
        }
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
}
