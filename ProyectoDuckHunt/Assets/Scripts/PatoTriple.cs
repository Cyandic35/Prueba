using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatoTriple : MonoBehaviour, IDamageable
{
    private int health = 3;

    private AudioSource myAudioSource;
    private SpriteRenderer patoRender;
    private Collider2D patoCollider;

    public IEnumerator PatoDestroy()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    private void Start()
    {
        myAudioSource = GetComponentInChildren<AudioSource>();
        patoRender = GetComponent<SpriteRenderer>();
        patoCollider = GetComponent<Collider2D>();
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
            myAudioSource.Play();
            patoRender.enabled = false;
            patoCollider.enabled = false;
            StartCoroutine(DestroyCoroutine());
        }
    }

    public IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(myAudioSource.clip.length);
        Destroy(gameObject);
    }
}