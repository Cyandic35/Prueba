using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaJoystickInput : MonoBehaviour, IPalaInput
{
    public FixedJoystick joystick;

    public float Vertical { get; private set; }

    public void GetInput()
    {
        Vertical = joystick.Vertical;
    }

    private void Update()
    {
        GetInput();
    }
}