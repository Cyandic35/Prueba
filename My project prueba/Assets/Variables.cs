using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int numero1 = 5;
    public int numero2 = 5;
    public int resultado;


    // Start is called before the first frame update
    void Start()
    {
        if ( numero1 >= numero2 )
        {
            Debug.Log("Cagaste hermano.");
        }
        else
        {
            Debug.Log("Buena esa.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
