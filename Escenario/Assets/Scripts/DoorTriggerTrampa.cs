using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerTrampa : PlayerTrigger
{
    public Animator DoorAnimator;

    private bool doorIsOpen = true;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        DoorAnimator.SetBool("OpenDoor", doorIsOpen);
    }
}