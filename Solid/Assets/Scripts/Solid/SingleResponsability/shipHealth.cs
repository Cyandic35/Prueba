using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipHealth : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private void Start()
    {
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
    }
}