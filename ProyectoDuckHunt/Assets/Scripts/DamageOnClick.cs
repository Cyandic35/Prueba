using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnClick : MonoBehaviour
{
    private int damageAmount = 1;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.rigidbody != null)
            {
                IDamageable damageable = hit.collider.GetComponent<IDamageable>();
                damageable.TakeDamage(damageAmount);
            }
        }
    }
}