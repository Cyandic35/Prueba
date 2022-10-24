using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche
{
    public string Marca = "Audi";
    public float Precio = 30000;



    public void Arrancar()
    {
        Debug.Log("He arrancado el coche.");
    }

    public void Frenar ()
    {
        Debug.Log("He frenado el coche.");
    }
}
