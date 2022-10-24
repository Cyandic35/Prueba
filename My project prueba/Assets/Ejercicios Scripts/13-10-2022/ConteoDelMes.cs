using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConteoDelMes : MonoBehaviour
{
    public int Mes;

    // Start is called before the first frame update
    void Start()
    {
        switch (Mes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Debug.Log("Este mes tiene 31 días.");
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Debug.Log("Este mes tiene 30 días.");
                break;

            case 2:
                Debug.Log("Este mes tiene 28 días, 29 si es año bisiesto.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
