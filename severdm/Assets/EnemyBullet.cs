using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBullet : MonoBehaviour
{
    public float speed;

    protected virtual void Start()
    {
        speed = 10;
    }


    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
    private void Awake()
    {
        Destroy(gameObject, 2.5f);
    }
}