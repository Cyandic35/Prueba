using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprovacionEdad : MonoBehaviour
{
    public int EdadIngresada = 16; //Es un ejemplo, esta podr�a variar.
    public int EdadMinima = 18; //Esta es invariable, es la edad de corte.

    // Start is called before the first frame update
    void Start()
    {
        if (EdadMinima <= EdadIngresada)
        {
            Debug.Log("Enhorabuena, puedes ir a la c�rcel.");
        }
        else
        {
            Debug.Log("�Qu� haces aqu�? Vete a ver Pocoy�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
