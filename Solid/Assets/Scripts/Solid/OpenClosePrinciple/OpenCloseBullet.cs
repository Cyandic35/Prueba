using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseBullet : OpenCloseProyectile
{
    public override void ShootProjectile(Vector3 shootDirection)
    {
        rb.AddForce(shootDirection * shootForce, ForceMode.Impulse);
    }
}