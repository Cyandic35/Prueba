using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectángulo
{
    public float Anchura;
    public float Altura;
    public float Profundidad;


    public float Area()
    {
        return Anchura * Altura;
    }

    public float Perímetro()
    {
        return (Anchura + Altura) * 2;
    }

    public float Volumen()
    {
        return Anchura * Altura * Profundidad;
    }
}