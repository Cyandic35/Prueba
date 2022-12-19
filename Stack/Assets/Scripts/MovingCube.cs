using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public float Speed = 2;

    public static MovingCube currentCube;
    public static MovingCube lastCube;

    public MovingDirection direction = MovingDirection.z;

    private void Update()
    {
        if (direction == MovingDirection.z)
        {
            transform.position += transform.forward * Time.deltaTime * Speed;
        }
        else if (direction == MovingDirection.x)
        {
            transform.position += transform.right * Time.deltaTime * Speed;
        }
    }

    private void OnEnable()
    {
        if (lastCube == null)
        {
            lastCube = GameObject.FindGameObjectWithTag("Initial").GetComponent<MovingCube>();
        }

        transform.localScale = new Vector3(lastCube.transform.localScale.x, transform.localScale.y, lastCube.transform.localScale.z);

        currentCube = this;
    }

    public void StopCube()
    {
        Speed = 0;

        float difference = GetDifference();

        float max = direction == MovingDirection.z ? lastCube.transform.localScale.z : lastCube.transform.localScale.x;

        if (Math.Abs(difference) > max)
        {
            lastCube = null;
            currentCube = null;
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

        float dir = difference > 0 ? -1 : 1;

        if (direction == MovingDirection.z)
        {
            SplitCubeOnZ(difference, dir);
        }

        lastCube = this;
    }

    private void SplitCubeOnZ(float difference, float dir)
    {
        float newSize = lastCube.transform.localScale.z - Math.Abs(difference);
        float fallingCubeSize = transform.localScale.z - newSize;
        float newPos = transform.position.z + (difference / 2);

        transform.position = new Vector3(transform.position.x, transform.position.y, newPos);
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, newSize);

        float cubeEdge = transform.position.z + (newSize / 2) * dir;
        float fallingCubePos = cubeEdge + fallingCubeSize / 2 * dir;

        CreateFallingCube(fallingCubeSize, fallingCubePos);
    }

    private void SplitCubeOnX(float difference, float dir)
    {
        float newSize = lastCube.transform.localScale.x - Math.Abs(difference);
        float fallingCubeSize = transform.localScale.x - newSize;
        float newPos = transform.position.x + (difference / 2);

        transform.position = new Vector3(newPos, transform.position.y, transform.position.z);
        transform.localScale = new Vector3(newSize, transform.localScale.y, transform.localScale.z);

        float cubeEdge = transform.position.x + (newSize / 2) * dir;
        float fallingCubePos = cubeEdge + fallingCubeSize / 2 * dir;

        CreateFallingCube(fallingCubeSize, fallingCubePos);
    }

    public void CreateFallingCube(float fallingCubeSize, float fallingCubePos)
    {
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        if (direction == MovingDirection.z)
        {
            cube.transform.position = new Vector3(transform.position.x, transform.position.y, fallingCubePos);
            cube.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, fallingCubeSize);
        }
        else
        {
            cube.transform.position = new Vector3(transform.position.x, transform.position.z, fallingCubePos);
            cube.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.z, fallingCubeSize);
        }

        cube.AddComponent<Rigidbody>();

        Destroy(cube.gameObject, 3);
    }

    private float GetDifference()
    {
        if (direction == MovingDirection.z)
        {
            return lastCube.transform.position.z - transform.position.z;
        }
        else
        {
            return lastCube.transform.position.x - transform.position.x;
        }
    }
}

public enum MovingDirection
{
    x, z
}