using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpObject : MonoBehaviour
{
    public Transform objectToMove;
    public Transform initialPos, finalPos;

    public float timeToLerp = 5;
    private float elapsedTime = 0;

    public AnimationCurve lerpCurve;

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        float lerpPercentage = elapsedTime / timeToLerp;

        objectToMove.position = Vector3.Lerp(initialPos.position, finalPos.position, lerpCurve.Evaluate(lerpPercentage));

        if (elapsedTime > timeToLerp)
        {
            elapsedTime = 0;
            Swap();
        }
    }

    public void Swap()
    {
        Transform temp = initialPos;
        initialPos = finalPos;
        finalPos = temp;
    }
}