using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    Spawner myLaneSpawner;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }


    private void Update()
    {
        if (IsAttackerInLane())
        {
            // TODO: Change animation state to shooting
            animator.SetBool("isAttacking", true);
        }
        else
        {
            // TODO: Change animation state to idle
            animator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawner()
    {
        Spawner[] spawners = FindObjectsOfType<Spawner>();
        foreach (Spawner spawner in spawners)
        {
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }

        return true;
    }

    public void Fire(float damage)
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }
}
