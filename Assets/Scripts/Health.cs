using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject explosionVFX;

    public void DealDamage(float dmgAmount)
    {
        health -= dmgAmount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        TriggerDeathVFX();
        Destroy(gameObject);
    }

    private void TriggerDeathVFX()
    {
        if (!explosionVFX)
        {
            return;
        }
        GameObject vfx = Instantiate(explosionVFX, transform.position, Quaternion.identity);
        Destroy(vfx, .5f);
    }
}
