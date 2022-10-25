using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public Vector3 rigidbodyVelocity;

    public float forceMagnitude;
    public Vector3 forceDirection;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        //myRigidbody.AddTorque(forceDirection * forceMagnitude, ForceMode.Impulse);
    }

    private void Update()
    {
        rigidbodyVelocity = myRigidbody.velocity;
    }

    private void FixedUpdate()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Detectada colisión.");
        MeshRenderer mesh = GetComponent<MeshRenderer>();

        mesh.material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Estoy colisionando.");
    }
}