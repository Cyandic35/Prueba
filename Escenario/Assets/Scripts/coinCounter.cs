using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinCounter : MonoBehaviour
{
    public int currentCoins;

    public Text coinText;

    public void getCoins(int coinAmount)
    {
        currentCoins += coinAmount;

        if (coinText != null)
        {
            coinText.text = currentCoins.ToString();
        }
        else
        {
            Debug.LogError("Recuerda pasar el objeto en Unity.");
        }
        Debug.Log("Llevas recogidas " + currentCoins + " peseticas");
        coinText.text = currentCoins.ToString();
    }
}