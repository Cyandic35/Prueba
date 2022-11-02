using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movementSpeed = 5;
    public float jumpForce = 10;
    private float xDirection;
    public Transform[] groundCheck;
    public LayerMask groundMask;
    public float checkgroundDistance = 0.2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private bool IsGrounded()
    {
        for (int i = 0; i < groundCheck.Length; i++)
        {
            if (Physics2D.Raycast(groundCheck[i].position, -groundCheck[i].up, checkgroundDistance, groundMask))
            {
                return true;
            }
        }
        return false;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(xDirection * movementSpeed, rb.velocity.y);
    }
}