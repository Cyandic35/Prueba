using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseState : MonoBehaviour, IState
{
    public IState RunCurrentState()
    {
        return this;
    }
}