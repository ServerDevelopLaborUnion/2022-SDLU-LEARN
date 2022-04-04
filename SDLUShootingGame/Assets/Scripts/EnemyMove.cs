using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject bullet = null;
    public UIManager uIManager = null;
    public float heart = 1f;
    public float shootDuration = 2f;
    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        StartCoroutine(BulletFire1());
        StartCoroutine(BulletFire2());
    }

    void Update()
    {
        
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Bullet"))
        {
            uIManager.SetHeartBoxAmount(heart -= 0.01f);
            if(heart <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    private IEnumerator BulletFire1()
    {
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                float cnt = 0;
                yield return new WaitForSeconds(shootDuration);
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt));
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt + 7.5f));
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt + 15));
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt + 352.5f));
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt + 345));
                cnt += 7.5f;
            }
            yield return new WaitForSeconds(2);
        }
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                float cnt = 0;
                yield return new WaitForSeconds(shootDuration);
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt));
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt + 7.5f));
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt + 15));
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt + 352.5f));
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, cnt + 345));
                cnt -= 7.5f;
            }
            yield return new WaitForSeconds(2);
        }
    }
    private IEnumerator BulletFire2()
    {
        yield return new WaitForSeconds(30f);
        for(int i = 0; i < 5; i++)
        {
            for(int j = 6; j >= 0; j -= 2)
            {
                yield return new WaitForSeconds(shootDuration);
                for(int k = 0; k < 24; k++)
                {
                    Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, j + k * 15));
                }
            }
            yield return new WaitForSeconds(1);
        }
    }
    private IEnumerator BulletFire3()
    {
        yield return new WaitForSeconds(45f);
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j <= 30; j += 6)
            {
                yield return new WaitForSeconds(shootDuration);
                for(int k = 0; k < 24; k++)
                {
                    Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, j + k * 15));
                }
            }
            yield return new WaitForSeconds(1);
        }
    }
}
