using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove21 : MonoBehaviour
{
    [SerializeField]
    public float speed = 15f;

    private Rigidbody2D rb = null;

    public GameObject bullet = null;

    public float shootDuration = 0.8f;

   
    public Slider hpSlider;
    //public float hp = 100;
    //public float maxhp = 100;
    public float Damage = 0.2f;




    private void Start()
    {
        //hpSlider.value = (float)hp / (float)maxHp;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Shooting());
    }

    void Update()
    {
        Move();

    }

    private void Move()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(hori, verti).normalized * speed;
    }




    private IEnumerator Shooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootDuration);
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            hpSlider.value -= Damage;
            if (hpSlider.value == 0)
            {
                Destroy(this.gameObject);
              
               
            }
        }
    }
    //public void DecreasHp()
    //{
    //    hp -= Damage;
    //}
    //public void Hppbar()
    //{
    //    hpSlider.value = (float)hp / (float)maxHp;
    //}
    public void GameOver()
    {

    }

}