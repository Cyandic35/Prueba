using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llaveUso : PlayerTrigger
{
    public int amountToTake = -1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        LlaveCounter counter = playerObject.GetComponent<LlaveCounter>();
        counter.getLlaves(amountToTake);
    }
}