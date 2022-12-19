using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public MovingCube movingCubePrefab;
    public MovingDirection direction;

    public void Spawn()
    {
        var cube = Instantiate(movingCubePrefab);
        cube.direction = direction;
        float x = direction == MovingDirection.x ? transform.position.x : MovingCube.lastCube.transform.position.x;
        float y = MovingCube.lastCube.transform.position.y + movingCubePrefab.transform.localScale.y;
        float z = direction == MovingDirection.z ? transform.position.z : MovingCube.lastCube.transform.position.z; ;

        cube.transform.position = new Vector3(x, y, z);
    }
}