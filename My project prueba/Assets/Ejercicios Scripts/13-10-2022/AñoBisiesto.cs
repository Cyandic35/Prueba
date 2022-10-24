using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AñoBisiesto : MonoBehaviour
{
    public int AñoIngresado = 1996;

    // Start is called before the first frame update
    void Start()
    {
        if (AñoIngresado % 4 == 0 && AñoIngresado % 100 == 0 || AñoIngresado % 400 == 0)
        {
            Debug.Log(AñoIngresado + "es un año bisiesto.");
        }

        else
        {
            Debug.Log(AñoIngresado + "no es un año bisiesto.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
