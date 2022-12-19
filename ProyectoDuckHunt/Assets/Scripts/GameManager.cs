using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startPanel, gamePanel, endPanel;
    public Text timeleftText;
    public float playTime;
    private float timeLeft;

    public int totalPoints;

    public Text pointText, finalText;

    public void start()
    {
        pointText.text = PlayerPrefs.GetInt("pointText").ToString();
        finalText.text = PlayerPrefs.GetInt("pointText").ToString();
    }

    private void StartGame()
    {
        startPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public IEnumerator GameOver()
    {
        yield return new WaitForSeconds(playTime);
        gamePanel.SetActive(false);
        endPanel.SetActive(true);
    }

    public void Update()
    {
        timeLeft -= Time.deltaTime;
        timeleftText.text = timeLeft.ToString("f0");
    }

    public void Restart()
    {
        timeLeft = playTime;
        FindObjectOfType<PointCounter>().resetPoints();
        StartCoroutine(GameOver());
    }
}