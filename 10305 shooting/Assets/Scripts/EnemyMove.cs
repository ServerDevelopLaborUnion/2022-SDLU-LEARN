using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject explosinFactory;

    public float health = 3;
    
    public float speed;

    private void Hpgage()
    {
        health -= 1;
    }

    private void Update()
    {
        Vector3 dir = Vector3.down;
        transform.position += dir * speed * Time.deltaTime;
        if (health <= 0)
        {
            Destroy(gameObject);
            GameObject smObject = GameObject.Find("ScoreManager");
            ScoreManger sm = smObject.GetComponent<ScoreManger>();
            sm.currentScore++;
            sm.currentScoreUI.text = "score : " + sm.currentScore;

        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BorderEnemy" )
            Destroy(gameObject);
        if(other.gameObject.tag == "Bullet")
        {
            Hpgage();
            GameObject explosion = Instantiate(explosinFactory);
            explosion.transform.position = transform.position;
        }
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject explosion = Instantiate(explosinFactory);
            explosion.transform.position = transform.position;


        }




    

    }


}
