using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed;
    protected new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        rigidbody2D.position = new Vector2(rigidbody2D.position.x, 0f);
        rigidbody2D.velocity = Vector2.zero;
    }
}
