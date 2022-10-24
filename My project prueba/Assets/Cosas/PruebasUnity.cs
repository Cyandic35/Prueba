using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebasUnity : MonoBehaviour
{
    public GameObject miObjeto;

    public Transform miTransform;

    // Start is called before the first frame update
    private void Start()
    {
        Vector3 nuevaEscala = new Vector3(2, 2, 2);
        miTransform.localScale = nuevaEscala;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}