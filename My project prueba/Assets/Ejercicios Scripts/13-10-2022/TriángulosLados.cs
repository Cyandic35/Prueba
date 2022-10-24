using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriángulosLados : MonoBehaviour
{
    public int lado1 = 3;
    public int lado2 = 4;
    public int lado3 = 5;
    // Start is called before the first frame update
    void Start()
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            Debug.Log("Es un triángulo equilátero.");
        }

        else if (lado1 == lado2 || lado1 == lado3 || lado2 ==lado3)
        {
            Debug.Log("Es un triángulo isósceles.");
        }

        else
        {
            Debug.Log("Es un triángulo escaleno.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
