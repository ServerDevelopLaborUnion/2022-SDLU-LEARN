using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    public float _playerSpeed = 5f;
    public GameObject Bullet = null;
    public UIManager uIManager = null;
    private Rigidbody2D rigid = null;
    public float shootDuration = 2f;
    public float life = 3f;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        StartCoroutine(Wait());
        StartCoroutine(BulletFire());

        uIManager = FindObjectOfType<UIManager>();
    }
    void Update()
    {
        Move();
    }
    private void Move() 
    {
        float hori = Input.GetAxisRaw("Horizontal");
		float verti = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(hori, verti) * _playerSpeed * Time.deltaTime);
        rigid.velocity = new Vector2(hori, verti).normalized * _playerSpeed;
        
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(4f);
    }
    private IEnumerator BulletFire()
    {
        while(true)
        {
            yield return new WaitForSeconds(shootDuration);
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }
    protected void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            life -= 1f;
            if(life <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
