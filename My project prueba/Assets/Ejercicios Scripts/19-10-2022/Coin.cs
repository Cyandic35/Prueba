using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : PlayerTrigger
{
    public int amountToGive = 1;

    private AudioSource myAudioSource;

    private MeshRenderer coinMesh;
    private Collider coinCollider;

    private void Start()
    {
        myAudioSource = GetComponentInChildren<AudioSource>();
        coinMesh = GetComponentInChildren<MeshRenderer>();
        coinCollider = GetComponentInChildren<Collider>();
    }

    public override void OnPlayerEnter(GameObject playerObject)
    {
        coinCounter counter = playerObject.GetComponent<coinCounter>();
        counter.getCoins(amountToGive);
        myAudioSource.Play();
        coinMesh.enabled = false;
        coinCollider.enabled = false;
        StartCoroutine(DestroyCoinCoroutine());
    }

    public IEnumerator DestroyCoinCoroutine()
    {
        yield return new WaitForSeconds(myAudioSource.clip.length);
        Destroy(gameObject);
    }
}