using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatoSpawn : MonoBehaviour
{
    public GameObject[] balaPrefab;
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
            int randPato = Random.Range(0, balaPrefab.Length);
            Instantiate(balaPrefab[randPato], shootingPosition[rand].position, shootingPosition[rand].rotation);
        }
    }
}