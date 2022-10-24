using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocheNuevo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Coche micoche = new Coche();
        
        micoche.Arrancar();
        micoche.Frenar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
