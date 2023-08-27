using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0f)
        {
            if (ball.transform.position.y > transform.position.y)
            {
                rigidbody2D.AddForce(Vector2.up * paddleSpeed);
            }
            else if (ball.transform.position.y < transform.position.y)
            {
                rigidbody2D.AddForce(Vector2.down * paddleSpeed);

            }
        }
        else
        {
            if (ball.transform.position.y > 0f)
            {
                rigidbody2D.AddForce(Vector2.down * paddleSpeed);

            }
            else if (ball.transform.position.y < 0f)
            {
                rigidbody2D.AddForce(Vector2.up * paddleSpeed);
            }
        }
    }
}
