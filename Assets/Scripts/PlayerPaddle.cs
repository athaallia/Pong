using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 direction;

    public bool isPlayer1 = true;

    private void Update()
    {
        if (isPlayer1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                direction = Vector2.up;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                direction = Vector2.down;
            }
            else
            {
                direction = Vector2.zero;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direction = Vector2.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                direction = Vector2.down;
            }
            else
            {
                direction = Vector2.zero;
            }
        }
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            rigidbody2D.AddForce(direction * this.paddleSpeed);
        }
    }
}
