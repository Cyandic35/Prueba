using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject cannonBallPrefab;

    public float shootForce;
    public float timeToShoot;
    private float timeSinceLastShot;

    private void Shoot()
    {
        GameObject cannonBall = Instantiate(cannonBallPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody cannonballRigidbody = cannonBall.GetComponent<Rigidbody>();
        cannonballRigidbody.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);
    }

    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        if (timeSinceLastShot >= timeToShoot)
        {
            Shoot();
            timeSinceLastShot = 0;
        }
    }
}