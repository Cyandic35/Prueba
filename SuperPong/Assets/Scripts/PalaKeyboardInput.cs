using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaKeyboardInput : MonoBehaviour, IPalaInput
{
    public float Vertical { get; private set; }

    public void GetInput()
    {
        Vertical = Input.GetAxis("Vertical");
    }

    private void Update()
    {
        GetInput();
    }
}