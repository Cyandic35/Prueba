using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipCannon : MonoBehaviour
{
    public GameObject projectilePrefab;

    public Transform shootPosition;

    public float shootForce = 30;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(projectilePrefab, shootPosition.position, shootPosition.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(shootPosition.forward * shootForce, ForceMode.Impulse);
        }
    }
}