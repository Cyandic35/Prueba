using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public float countDownTime;

    public delegate void OnCountDownFinish();

    //Aplicando el System de Delegate
    //public System.Action endCountDown;

    public OnCountDownFinish endCountDown;

    private void Start()
    {
        StartCoroutine(CountDownCoroutine());
    }

    public IEnumerator CountDownCoroutine()
    {
        yield return new WaitForSeconds(countDownTime);
        if (endCountDown != null)
        {
            endCountDown();
        }
    }
}