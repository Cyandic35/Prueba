using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageMaker : PlayerTrigger
{
    public int damageAmount = 1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        playerHealth health = playerObject.GetComponent<playerHealth>();
        health.TakeDamage(damageAmount);
    }
}