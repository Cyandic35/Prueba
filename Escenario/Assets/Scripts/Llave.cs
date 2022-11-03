using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : PlayerTrigger
{
    public int amountToGive = 1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        llaveCounter counter = playerObject.GetComponent<llaveCounter>();
        counter.getLlaves(amountToGive);
        gameObject.SetActive(false);
    }
}