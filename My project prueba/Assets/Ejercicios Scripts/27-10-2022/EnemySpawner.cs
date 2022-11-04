using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPositions;
    public float timeToSpawn = 5f;
    private float timeSinceLastSpawn;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn > timeToSpawn)
        {
            timeSinceLastSpawn = 0;
            int rand = Random.Range(0, spawnPositions.Length);
            Transform randomPos = spawnPositions[rand];
            Instantiate(enemyPrefab, randomPos.position, Quaternion.identity);
        }
    }
}