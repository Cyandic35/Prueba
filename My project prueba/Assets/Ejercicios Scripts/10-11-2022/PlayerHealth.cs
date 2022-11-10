using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : Health
{
    public Image deathScreen;
    private float timeToFade = 3;

    private FirstPersonMovement playerMovement;
    private Jump playerJump;
    private Crouch playerCrouch;

    private void Awake()
    {
        playerMovement = GetComponentInParent<FirstPersonMovement>();
        playerJump = GetComponentInParent<Jump>();
        playerCrouch = GetComponentInParent<Crouch>();
    }

    public override void Die()
    {
        deathScreen.DOFade(1, timeToFade);
        playerMovement.enabled = false;
        playerJump.enabled = false;
        playerCrouch.enabled = false;
        StartCoroutine(DeathCoroutine());
    }

    public IEnumerator DeathCoroutine()
    {
        yield return new WaitForSeconds(timeToFade);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}