using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masmenoscero : MonoBehaviour
{
    public int num = 17;
    // Start is called before the first frame update
    void Start()
    {
        if (num >= 0)
        {
            Debug.Log("Mayor que 0.");
        }

        else
        {
            Debug.Log("Menor que 0.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
