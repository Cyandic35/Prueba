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
        Debug.Log("Podr�as haber usado una calculadora y es m�s f�cil, pero el area del coso este es de " + area + " cent�metros.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
