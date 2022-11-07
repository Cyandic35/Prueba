using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSaveTest : MonoBehaviour
{
    private string nameKey = "playerName";
    public Text nameText;

    private void Start()
    {
        Debug.Log("el jugador se llama " + PlayerPrefs.GetString(nameKey));
    }

    public void SavePlayerName()
    {
        PlayerPrefs.SetString(nameKey, nameText.text);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}