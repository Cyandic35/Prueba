using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : PlayerTrigger
{
    public int amountToGive = 1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        coinCounter counter = playerObject.GetComponent<coinCounter>();
        counter.getCoins(amountToGive);
        gameObject.SetActive(false);
    }
}