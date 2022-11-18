using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public IState currentState;

    private void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        IState nextState = currentState.RunCurrentState();
        if (nextState != null)
        {
            currentState = nextState;
        }
    }
}