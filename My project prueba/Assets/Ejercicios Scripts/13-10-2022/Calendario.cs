using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendario : MonoBehaviour
{
    public int Día;
    public int Mes;

    // Start is called before the first frame update
    void Start()
    {
        switch (Día)
        {
            case 1:
                Debug.Log("Hoy es Lunes.");
                break;

            case 2:
                Debug.Log("Hoy es Martes.");
                break;

            case 3:
                Debug.Log("Hoy es Miércoles.");
                break;

            case 4:
                Debug.Log("Hoy es Jueves.");
                break;

            case 5:
                Debug.Log("Hoy es Viernes.");
                break;

            case 6:
                Debug.Log("Hoy es Sábado.");
                break;

            case 7:
                Debug.Log("Hoy es Domingo.");
                break;

            default:
                Debug.Log("Ingrese un valor del 1 al 7.");
                break;
        }

        switch (Mes)
        {
            case 1:
                Debug.Log("Estamos a Enero.");
                break;

            case 2:
                Debug.Log("Estamos a Febrero.");
                break;

            case 3:
                Debug.Log("Estamos a Marzo.");
                break;

            case 4:
                Debug.Log("Estamos a Abril.");
                break;

            case 5:
                Debug.Log("Estamos a Mayo.");
                break;

            case 6:
                Debug.Log("Estamos a Junio.");
                break;

            case 7:
                Debug.Log("Estamos a Julio.");
                break;

            case 8:
                Debug.Log("Estamos a Agosto.");
                break;

            case 9:
                Debug.Log("Estamos a Septiembre.");
                break;

            case 10:
                Debug.Log("Estamos a Octubre.");
                break;

            case 11:
                Debug.Log("Estamos a Noviembre.");
                break;

            case 12:
                Debug.Log("Estamos a Diciembre.");
                break;

            default:
                Debug.Log("Ingrese un valor entre 1 y 12.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
