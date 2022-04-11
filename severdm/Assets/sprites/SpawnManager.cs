using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject player = null;
    public GameObject bullet = null;
    public  GameObject Enemy = null;
    public Vector3 spawnPos = Vector3.zero;
    public GameObject enemy = null;
    public Transform maxPos = null;
    public Transform minPos = null;
    public GameObject enemy2 = null;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnEnemy2());

        //GameObject g = Instantiate(player, spawnPos, Quaternion.identity);
        //rb = g.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Move();
    // }
   
    private void Move()
    {

        float hori = Input.GetAxisRaw("Horizontal");
   
        float verti = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(hori, verti).normalized * 10f;
    }


    private void SpawnBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, rb.transform.position, Quaternion.identity);
        }
    }

    private IEnumerator SpawnEnmy()
    {
        
        yield return null;


    }
    private IEnumerator SpawnEnmy2()
    {

        yield return null;


    }

    private IEnumerator SpawnEnemy()
    {
        
        while(true)
        {
            yield return new WaitForSeconds(1);
            Instantiate(enemy, new Vector2(Random.Range(minPos.position.x, maxPos.position.x), maxPos.position.y), enemy.transform.rotation);
            yield return null;
        }

    }
    private IEnumerator SpawnEnemy2()
    {

        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy2, new Vector2(Random.Range(minPos.position.x, maxPos.position.x), maxPos.position.y), enemy2.transform.rotation);
            yield return null;
        }

    }

}