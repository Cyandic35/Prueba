using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
    public float timeToFall = 0.8f;
    private float timeSinceLastMovementDown = 0;

    private int width = 10;
    private int height = 20;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
            if (!ValidMovement())
            {
                transform.position -= Vector3.left;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
            if (!ValidMovement())
            {
                transform.position -= Vector3.right;
            }
        }
        if (Time.time - timeSinceLastMovementDown > (Input.GetKey(KeyCode.S) ? timeToFall / 10 : timeToFall))
        {
            transform.position += Vector3.down;
            timeSinceLastMovementDown = Time.time;
            if (!ValidMovement())
            {
                transform.position -= Vector3.down;
                this.enabled = false;
            }
        }
    }

    public bool ValidMovement()
    {
        foreach (Transform child in transform)
        {
            int roundedX = Mathf.RoundToInt(child.position.x);
            int roundedY = Mathf.RoundToInt(child.position.y);
            if (roundedX < 0 || roundedX >= width || roundedY < 0 || roundedY >= height)
            {
                return false;
            }
        }
        return true;
    }
}