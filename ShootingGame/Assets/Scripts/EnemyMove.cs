using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ExplosionBullet
//BulletMove의 자식 클래스
public class EnemyMove : BulletMove
{
    //private
    protected override void Start() {
        speed = 10;
        
    }
    

    //IsTrigger가 켜진 상태로 들어갔을때
    protected override void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") || other.CompareTag("Bullet")){
            Destroy(gameObject);
        }
    }
}