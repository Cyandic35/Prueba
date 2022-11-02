using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 InitialPosition;

    public Text healthText;

    public float timeToDamage = 2;
    public float timeSinceDamage = 0;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
        healthText.text = currentHealth.ToString();
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            healthText.text = currentHealth.ToString();
            timeSinceDamage += Time.deltaTime;
            if (timeSinceDamage <= timeToDamage)
            {
                damageTaken = 0;
            }
        }
    }
}