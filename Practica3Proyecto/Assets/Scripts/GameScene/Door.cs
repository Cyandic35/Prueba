using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator doorAnimator;
    private bool animatorBoolState = true;

    private void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    public void UseDoor()
    {
        doorAnimator.SetBool("Abierta", animatorBoolState);
        animatorBoolState = !animatorBoolState;
    }
}