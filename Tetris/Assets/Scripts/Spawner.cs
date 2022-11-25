using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] blocksPrefabs;

    private void Start()
    {
        SpawnBlock();
    }

    public void SpawnBlock()
    {
        Instantiate(blocksPrefabs[Random.Range(0, blocksPrefabs.Length)], transform.position, Quaternion.identity);
    }
}