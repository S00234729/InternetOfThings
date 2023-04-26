using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D body;
    float vert;
    Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //input
        vert = Input.GetAxisRaw("Vertical");

        velocity.y = movespeed * vert;
        body.velocity = velocity;
    }
}
