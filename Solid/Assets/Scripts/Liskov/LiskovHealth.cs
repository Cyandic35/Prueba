using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiskovHealth : MonoBehaviour
{
    public float MaxHealth = 10;
    protected float currentHealth;

    private void Start()
    {
        currentHealth = MaxHealth;
    }

    public virtual void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
    }
}