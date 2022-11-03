using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class llaveCounter : MonoBehaviour
{
    public int currentLlaves;

    public Text llaveText;

    public void getLlaves(int llaveAmount)
    {
        currentLlaves += llaveAmount;

        if (llaveText != null)
        {
            llaveText.text = currentLlaves.ToString();
        }
        else
        {
            Debug.LogError("Recuerda pasar el objeto en Unity.");
        }
        llaveText.text = currentLlaves.ToString();
    }
}