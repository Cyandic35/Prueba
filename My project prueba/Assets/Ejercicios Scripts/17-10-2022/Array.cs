using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public int[] miArray;

    void Start()
    {
        
    }



public void Rand()
    {
        for (int i = 0; i < miArray.Length; i++)
        {
            miArray[i] = Random.Range(10, 1000);
        }
    }
    void Update()
    {
        
    }
}
