using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucle : MonoBehaviour
{
    public int inicio;
    public int final;
    public int result = 1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = final; i > 0; i--)
            result *= i;
        { Debug.Log(result); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
