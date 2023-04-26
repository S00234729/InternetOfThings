using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float movespeed;
    public AudioSource sound;
    public Rigidbody2D body;
    Vector2 direction;

    

    private void Start()
    {
        ResetPosition();
        SetDirection();
    }
    void ResetPosition()
    {
        transform.position = Vector2.zero;

        body.velocity = Vector2.zero;
    }
    void SetDirection()
    {
        direction.x = Random.Range(20, 180);
        direction.y = Random.Range(20, 360);
        direction.Normalize();
        body.velocity = direction * movespeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trigger"))
        {
            ResetPosition();
            SetDirection();


        }
    }
}
