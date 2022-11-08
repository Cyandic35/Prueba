using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveDoor : MonoBehaviour
{
    public Animator DoorAnimator;

    private bool doorIsOpen = true;

    public void Puerta()
    {
        DoorAnimator.SetBool("OpenDoor", doorIsOpen);
        doorIsOpen = !doorIsOpen;
    }
}