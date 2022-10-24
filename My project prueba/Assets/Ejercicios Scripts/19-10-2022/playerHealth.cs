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
            Debug.Log("Samatao Paco.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //transform.position = InitialPosition;
            //currentHealth = MaxHealth;
            //healthText.text = currentHealth.ToString();
        }
        else
        {
            Debug.Log("Sigues vivo, pero te faltan " + currentHealth + " para saspicharla.");
            healthText.text = currentHealth.ToString();
        }
    }
}