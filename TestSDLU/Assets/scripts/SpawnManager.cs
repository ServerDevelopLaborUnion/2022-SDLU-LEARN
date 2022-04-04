using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SpawnManager : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rb = null;

    public GameObject bullet = null;

    public GameObject enemy = null;

    public float enemyDuration = 3f;

    public Transform maxPos = null;
    public Transform minPos = null;

    public float shootDuration = 0.5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Shooting());

        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {

        //���α��� ���� : -1  �ȴ����� : 0  ������ :1
        float hori = Input.GetAxisRaw("Horizontal");
        //���α��� �� : 1 �ȴ����� : 0 �� : -1
        float verti = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(hori, verti).normalized * speed;
    }

    // /// <summary>
    // /// �÷��̾� ������
    // /// </summary>
    // private void Move(){
    //     //���α��� ���� : -1  �ȴ����� : 0  ������ :1
    //     float hori = Input.GetAxisRaw("Horizontal");
    //     //���α��� �� : 1 �ȴ����� : 0 �� : -1
    //     float verti = Input.GetAxisRaw("Vertical");

    //     transform.Translate(new Vector2(hori , verti).normalized * speed * Time.deltaTime);
    // }   

    //"�ڷ�ƾ"


    private IEnumerator Shooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootDuration);
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {           
            Instantiate(enemy, new Vector2(Random.Range(minPos.position.x, maxPos.position.x), maxPos.position.y),enemy.transform.rotation);
            yield return null;
        }
    }

}