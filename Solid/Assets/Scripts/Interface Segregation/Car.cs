using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour, IDamageable
{
    private int health = 5;

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}