using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : BulletMove
{
    protected override void Start()
    {
        speed = 5;
        
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") || collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

}
