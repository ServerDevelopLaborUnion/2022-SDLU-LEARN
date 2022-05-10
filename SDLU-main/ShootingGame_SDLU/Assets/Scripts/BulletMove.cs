using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed = 15;

    private void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        BulletMovement();
    }

    private void BulletMovement()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy") || collision.CompareTag("FireEnemy"))
        Despawn();
    }
    private void Limit(){
        if(transform.position.x> GameManager.Instance._maxPosition.position.x ||
            transform.position.y> GameManager.Instance._maxPosition.position.y ||
            transform.position.x> GameManager.Instance._minPosition.position. x ||
            transform.position.y> GameManager.Instance._minPosition.position.y
        )
        {
            Destroy(gameObject);
        }
    }
    private void Despawn(){
        transform.SetParent(GameManager.Instance.Pooling);
        gameObject.SetActive(false);
    }
}
