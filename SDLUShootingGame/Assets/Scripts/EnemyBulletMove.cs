using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{
    public float _bulletSpeed = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        transform.Translate(new Vector2(0, _bulletSpeed) * Time.deltaTime);
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Blinder") || other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }   
}