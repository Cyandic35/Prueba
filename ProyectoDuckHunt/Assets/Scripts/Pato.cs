using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pato : GameManager, IDamageable
{
    private int health = 1;
    public int pointsGiven = 1;

    private void getPoints()
    {
        totalPoints += pointsGiven;
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            getPoints();
            Destroy(gameObject);
        }
    }
}