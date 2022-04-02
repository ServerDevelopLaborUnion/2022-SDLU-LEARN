using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    float EnemySpawnDelay = 0.5f;
    public GameObject Enemy;
    public Transform MinValue = null;
    public Transform MaxValue = null;

    void Start()
    {
        StartCoroutine(EnemyCreate());
    }

    private IEnumerator EnemyCreate()
    {
        while (true)
        {
            Instantiate(Enemy, new Vector2(Random.Range(MinValue.position.x, MaxValue.position.x), MaxValue.position.y), Quaternion.identity);
            yield return new WaitForSeconds(EnemySpawnDelay);
        }
    }
}
