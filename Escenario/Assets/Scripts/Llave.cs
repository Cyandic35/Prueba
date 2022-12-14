using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : PlayerTrigger
{
    public int amountToGive = 1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        LlaveCounter counter = playerObject.GetComponent<LlaveCounter>();
        counter.getLlaves(amountToGive);
        gameObject.SetActive(false);
    }
}