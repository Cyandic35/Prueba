using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatoMovement : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
}