using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public float points;

    public Text pointText;
    public Text finalText;

    public void Update()
    {
        if (pointText != null)
        {
            pointText.text = points.ToString();
        }
        else
        {
            Debug.LogError("Recuerda pasar el objeto en Unity.");
        }
        pointText.text = points.ToString();
        finalText.text = points.ToString();
    }

    public void getPoints()
    {
        points++;
    }

    public void resetPoints()
    {
        points = 0;
    }
}