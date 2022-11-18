using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackState : MonoBehaviour, IState
{
    public IState RunCurrentState()
    {
        return this;
    }
}