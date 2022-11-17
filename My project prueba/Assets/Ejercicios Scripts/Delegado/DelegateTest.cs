using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    public delegate void DoSomething();

    public DoSomething something;

    //Engloba las dos anteriores en una.
    //public System.Action DoAction;
    //public System.Action<int> actionExample;

    //public System.Func<int> myFunctionExample;

    //public UnityEvent miEventoDeUnity;

    public CountDown countDown;

    public GameObject objectToTurnOff;

    public Light lightToTurnOn;

    public MeshRenderer meshToChangeColor;
    public Color colorToChange;

    public void TurnObjectOff()
    {
        objectToTurnOff.SetActive(false);
    }

    public void ChangeColor()
    {
        meshToChangeColor.material.color = colorToChange;
    }

    public void TurnOnLight()
    {
        lightToTurnOn.enabled = true;
    }

    private void Start()
    {
        countDown.endCountDown += TurnOnLight;
        countDown.endCountDown += ChangeColor;
        countDown.endCountDown += TurnObjectOff;
    }

    public void Method1()
    {
        Debug.Log("He lanzado el método 1");
    }

    public void Method2()
    {
        Debug.Log("He lanzado el método 2");
    }
}