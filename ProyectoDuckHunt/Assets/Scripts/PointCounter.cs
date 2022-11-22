using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public int currentPoints;

    public Text pointText;

    public void getCoins(int pointAmount)
    {
        currentPoints += pointAmount;

        if (pointText != null)
        {
            pointText.text = currentPoints.ToString();
        }
        else
        {
            Debug.LogError("Recuerda pasar el objeto en Unity.");
        }
        pointText.text = currentPoints.ToString();
    }
}