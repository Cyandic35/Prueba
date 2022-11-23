using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaInput : MonoBehaviour
{
    private Rigidbody2D rb;
    private IPalaInput input;
    public float Speed = 10;
    private float vertical;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<IPalaInput>();
    }

    private void Update()
    {
        vertical = input.Vertical;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, vertical * Speed);
    }
}