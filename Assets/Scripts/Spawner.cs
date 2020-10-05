using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker attackerPrefab;

    bool spawn = true;
    

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    void SpawnAttacker()
    {
        Attacker newAttacker = Instantiate(attackerPrefab, transform.position, Quaternion.identity) as Attacker;
        newAttacker.transform.parent = transform;
    }
}
