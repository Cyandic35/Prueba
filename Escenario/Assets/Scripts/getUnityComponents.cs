using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getUnityComponents : MonoBehaviour
{
    public MeshRenderer mesh;

    public Collider[] colliders;

    // Start is called before the first frame update
    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        colliders = GetComponents<Collider>();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}