using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMove : MonoBehaviour
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
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
          Destroy(other.gameObject);
        }
    }
    private void Awake()
    {
        Destroy(gameObject, 2.5f);
    }
}