using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
    public GameObject startPanel, gamePanel, endPanel;
    public Text timeleftText;
    public float playTime;
    private float timeLeft;

    private bool timeIsTicking = false;

    public Text ClicksTotalText;

    private float TotalClicks;

    public void StartCountDown()
    {
        timeLeft = playTime;
        timeIsTicking = true;
    }

    private void Update()
    {
        if (timeIsTicking)
        {
            timeLeft -= Time.deltaTime;
            timeleftText.text = timeLeft.ToString();
            if (timeLeft <= 0)
            {
                timeIsTicking = false;
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        gamePanel.SetActive(false);
        endPanel.SetActive(true);
    }

    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = TotalClicks.ToString();
    }

    public void Restart()
    {
        TotalClicks = 0;
        ClicksTotalText.text = TotalClicks.ToString();
    }
}