using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LlaveCounter : MonoBehaviour
{
    public int currentLlaves;

    public Text llaveText;

    public GameObject candado;

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

    public void Update()
    {
        if (currentLlaves <= 0)
        {
            candado.SetActive(false);
        }
        else
        {
            candado.SetActive(true);
        }
    }
}