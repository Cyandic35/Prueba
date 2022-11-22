using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatoSpawn : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform[] shootingPosition;
    public float timeToShoot;
    private float timeSinceLastShoot = 0;

    public void Update()
    {
        timeSinceLastShoot += Time.deltaTime;
        if (timeSinceLastShoot > timeToShoot)
        {
            timeSinceLastShoot = 0;
            int rand = Random.Range(0, shootingPosition.Length);
            Instantiate(balaPrefab, shootingPosition[rand].position, shootingPosition[rand].rotation);
        }
    }
}