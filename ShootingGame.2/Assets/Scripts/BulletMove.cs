using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//EnemyMove의 부모 클래스
public class BulletMove : MonoBehaviour
{
    public float speed;

    protected virtual void Start() {
        speed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move(){
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    protected virtual void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Enemy")){
            Destroy(gameObject);
        }
    }
}