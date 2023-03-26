using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovementSpeed;

    Rigidbody2D body;
    float horizontal;
    Vector2 HorizontalForce;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        HorizontalForce.x = horizontal * MovementSpeed * Time.deltaTime;

        body.AddForce(HorizontalForce);
    }
}
