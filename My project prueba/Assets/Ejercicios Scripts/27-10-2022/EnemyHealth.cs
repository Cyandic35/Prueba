using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : Health
{
    private Animator myAnimator;
    public float timeToDie = 4;
    private NavMeshAgent agent;
    private Collider myCollider;

    private void Awake()
    {
        myCollider = GetComponent<Collider>();
        agent = GetComponent<NavMeshAgent>();
        myAnimator = GetComponentInChildren<Animator>();
    }

    public override void Die()
    {
        myCollider.enabled = false;
        myAnimator.SetTrigger("Ded");
        agent.isStopped = true;
        StartCoroutine(DedCoroutine());
    }

    public IEnumerator DedCoroutine()
    {
        yield return new WaitForSeconds(timeToDie);
        Destroy(gameObject);
    }
}