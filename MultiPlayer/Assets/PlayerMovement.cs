using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{
    public float movementSpeed = 10;
    public float rotationSpeed = 60;

    private void Update()
    {
        if (isLocalPlayer)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            transform.position += transform.forward * vertical * movementSpeed * Time.deltaTime;
            transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
        }
    }
}