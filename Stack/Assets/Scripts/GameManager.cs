using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private CubeSpawner[] spawners;
    private int spawnerIndex = 1;

    private void Start()
    {
        spawners = FindObjectsOfType<CubeSpawner>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (MovingCube.currentCube != null)
            {
                MovingCube.currentCube.StopCube();

                spawnerIndex = spawnerIndex == 0 ? 1 : 0;

                spawners[spawnerIndex].Spawn();
            }
        }
    }
}