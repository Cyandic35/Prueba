using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPala : MonoBehaviour, IPalaInput
{
    public float Vertical { get; set; }

    public Ball ball;

    public void GetInput()
    {
        if (ball.rb.velocity.x > 0)
        {
            if (ball.transform.position.y > transform.position.y)
            {
                Vertical = 0.5f;
            }
            else
            {
                Vertical = -0.5f;
            }
        }
    }

    private void Update()
    {
        GetInput();
    }
}