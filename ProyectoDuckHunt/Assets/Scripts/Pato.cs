using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pato : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}