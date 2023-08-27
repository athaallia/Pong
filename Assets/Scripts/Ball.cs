using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed;
    private new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        AddStartingForce();
    }

    public void ResetPosition()
    {
        rigidbody2D.position = Vector3.zero;
        rigidbody2D.velocity = Vector3.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f;

        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) :
                                        Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y);
        rigidbody2D.AddForce(direction * this.ballSpeed);
    }

    public void AddForce(Vector2 force)
    {
        rigidbody2D.AddForce(force);
    }
}
