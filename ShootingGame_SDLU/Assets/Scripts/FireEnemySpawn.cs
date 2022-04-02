using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemySpawn : MonoBehaviour
{
    public GameObject FireEnemy;
    public float SpawnDelay = 10f;

    void Start()
    {
        StartCoroutine(FireEenemyCreate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator FireEenemyCreate()
    {
        while (true)
        {
            Instantiate(FireEnemy, new Vector2(-5, 8), Quaternion.identity);
            Instantiate(FireEnemy, new Vector2(5, 8), Quaternion.identity);
            yield return new WaitForSeconds(SpawnDelay);
        }
    }
}
