using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatoTriple : MonoBehaviour, IDamageable
{
    private int health = 3;

    public IEnumerator PatoDestroy()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    private void Start()
    {
        StartCoroutine(PatoDestroy());
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            FindObjectOfType<PointCounter>().getPoints();
            FindObjectOfType<PointCounter>().getPoints();
            FindObjectOfType<PointCounter>().getPoints();
            Destroy(gameObject);
        }
    }
}