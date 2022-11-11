using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public int numberOfObjectsInPool = 100;

    public GameObject poolObjectPrefab;

    private Queue<GameObject> poolQueue;

    private void Awake()
    {
        poolQueue = new Queue<GameObject>();

        for (int i = 0; i < numberOfObjectsInPool; i++)
        {
            GameObject poolObject = Instantiate(poolObjectPrefab, transform.position, transform.rotation);
            poolObject.SetActive(false);
            poolObject.transform.SetParent(transform);
            poolQueue.Enqueue(poolObject);
        }
    }

    public GameObject GetObjectFromPool(Vector3 poolObjectPosition, Quaternion poolObjectRotation)
    {
        GameObject poolObject = poolQueue.Dequeue();

        poolObject.SetActive(true);
        poolObject.transform.position = poolObjectPosition;
        poolObject.transform.rotation = poolObjectRotation;

        poolQueue.Enqueue(poolObject);

        return poolObject;
    }
}