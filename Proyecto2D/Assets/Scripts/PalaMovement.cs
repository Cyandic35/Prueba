using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movementSpeed = 5;    
    private float yDirection;     
            
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        yDirection = Input.GetAxisRaw("Vertical");                
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, yDirection * movementSpeed, 0);
    }
}