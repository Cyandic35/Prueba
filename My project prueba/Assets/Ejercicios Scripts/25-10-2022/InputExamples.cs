using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExamples : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pulsaste el espacio.");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Mantienes el espacio.");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Soltaste el espacio.");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clickaste el Mouse.");
        }
        //Lo de abajo sirve para mandos también.
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("No lo ves, pero estás saltando.");
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Atacaste con la espada.");
        }
    }
}