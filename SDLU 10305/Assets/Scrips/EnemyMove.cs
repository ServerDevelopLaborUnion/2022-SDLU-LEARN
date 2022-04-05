using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Vector3 dir;
    public float speed = 5f;
    
    void Start()
    {
        
        int randValue = UnityEngine.Random.Range(0, 10);
        if (randValue < 3)
        {
            GameObject target = GameObject.Find("player(1)");
            dir = target.transform.position-transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }

    
    void Update()
    {
        
        transform.position += dir * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
