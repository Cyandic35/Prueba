using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseTurret : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject missilePrefab;

    public Transform shootPoint;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    private void Fire()
    {
        if (bulletPrefab != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
            OpenCloseProyectile proyectile = bullet.GetComponent<OpenCloseProyectile>();
            if (proyectile != null)
            {
                proyectile.ShootProjectile(shootPoint.forward);
            }
        }
    }
}