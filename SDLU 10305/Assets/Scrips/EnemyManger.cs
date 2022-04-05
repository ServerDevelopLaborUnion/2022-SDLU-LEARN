using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManger : MonoBehaviour
{
    float minTime = 1;
    float maxTime = 5;
    float currentTime;
    public float createTime = 1;
    public GameObject enemyFactory;
    
    void Start()
    {
        currentTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            currentTime = 0;
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
