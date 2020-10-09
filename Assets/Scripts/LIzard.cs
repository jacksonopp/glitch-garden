using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIzard : Attacker
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;

        if (otherObject.GetComponent<Defender>())
        {
            Debug.Log("Lizard collided with object");
            //GetComponent<Attacker>().Attack(otherObject);
            Attack(otherObject);
            
        }
    }
}
