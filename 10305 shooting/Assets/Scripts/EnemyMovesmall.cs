using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovesmall : MonoBehaviour
{
    Vector3 dir;
    public float speed = 5f;
    public GameObject explosinFactory;
    void Start()
    {
        
        int randValue = UnityEngine.Random.Range(0, 10);
        if(randValue < 3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            GameObject explosion = Instantiate(explosinFactory);
            explosion.transform.position = transform.position;
            GameObject smObject = GameObject.Find("ScoreManager");
            ScoreManger sm = smObject.GetComponent<ScoreManger>();
            sm.currentScore++;
            sm.currentScoreUI.text = "score : " + sm.currentScore;

        }
        if (other.gameObject.tag == "BorderEnemy")
        {
            Destroy(gameObject);
        }


    }
    
    
        
    

}
