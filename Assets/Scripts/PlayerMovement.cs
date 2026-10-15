using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 3;
    public float jumpSpeed = 6;
    public float inGroundDumping;
    bool isGrounded;

    //Update is called once per frame
    void Update()
    {
        var rb = GetComponent<Rigidbody2D>();

        //Capture left and right directionals
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);

            // Alternate way
            // rb.linearVelocity = (Vector2.right * speed);
            new Vector2(speed, rb.linearVelocity.y);

        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);

            //Alternate way
            //rb.linearVelocity = (Vector2.left * speed);
        }

        else if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpSpeed);
            isGrounded = false;
        }

        else if (isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x * inGroundDumping, rb.linearVelocity.y);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag ("Ground"))
        {
            isGrounded = true;
        }
    }
}







   

