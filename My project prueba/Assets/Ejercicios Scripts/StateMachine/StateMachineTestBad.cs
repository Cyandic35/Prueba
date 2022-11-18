using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineTestBad : MonoBehaviour
{
    public enum States
    {
        chasing,
        idle,
        attacking
    }

    public States currentStates = States.idle;

    private void Update()
    {
    }

    public void StateMachine()
    {
        switch (currentStates)
        {
            case States.chasing:
                Chasing();
                break;

            case States.idle:
                Idle();
                break;

            case States.attacking:
                Attacking();
                break;

            default:
                break;
        }
    }

    public void Chasing()
    {
    }

    public void Idle()
    {
    }

    public void Attacking()
    {
    }
}