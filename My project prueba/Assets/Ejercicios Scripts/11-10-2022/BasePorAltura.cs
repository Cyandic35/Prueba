using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePorAltura : MonoBehaviour
{
    public float lado1 = 17;
    public float lado2 = 8;
    public float area;

    // Start is called before the first frame update
    void Start()
    {
        area = lado1 * lado2;
        Debug.Log("Podrías haber usado una calculadora y es más fácil, pero el area del coso este es de " + area + " centímetros.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
