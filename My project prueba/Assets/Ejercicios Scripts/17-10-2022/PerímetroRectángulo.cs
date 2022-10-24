using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerímetroRectángulo : MonoBehaviour
{

    public float res = 1;
    // Start is called before the first frame update
    void Start()
    {
        float i = Perímetro(5.6f, 7.8f);

        res = i;
        Debug.Log(i);
    }
    public float Perímetro(float alto, float ancho)
    { return alto * 2 + ancho * 2; }
    // Update is called once per frame
    void Update()
    {
        
    }
}
