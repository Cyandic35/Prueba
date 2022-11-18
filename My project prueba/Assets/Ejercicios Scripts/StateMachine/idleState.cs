using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleState : MonoBehaviour, IState
{
    public IState RunCurrentState()
    {
        return this;
    }
}