using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public Pool cubePool;

    private void FixedUpdate()
    {
        cubePool.GetObjectFromPool(transform.position, transform.rotation);
    }
}