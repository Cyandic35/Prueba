using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 InitialPosition;

    public Text healthText;

    public Image healthBar;

    public void UpdateHealthBar()
    {
        healthBar.fillAmount = Mathf.InverseLerp(0, MaxHealth, currentHealth);
    }

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
        UpdateHealthBar();
        if (healthText != null)
        {
            healthText.text = currentHealth.ToString();
        }
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (healthText != null)
        {
            healthText.text = currentHealth.ToString();
        }
        if (currentHealth <= 0)
        {
            Die();
            //Debug.Log("Samatao Paco.");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //transform.position = InitialPosition;
            //currentHealth = MaxHealth;
            //healthText.text = currentHealth.ToString();
        }
        else
        {
            Debug.Log("Sigues vivo, pero te faltan " + currentHealth + " para saspicharla.");
            //healthText.text = currentHealth.ToString();
        }
        UpdateHealthBar();
    }

    public virtual void Die()
    {
    }
}