using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove21 : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;
    [SerializeField]
    public float speed = 15f;

    private Rigidbody2D rb = null;

    public GameObject bullet = null;

    public float shootDuration = 0.8f;

   
    public Slider hpSlider;
   
    public float Damage = 0.2f;

    //public bool isTOuchTop;
    //public bool isTOuchBottom;
    //public bool isTOuchLeft;
    //public bool isTOuchRight;
   




    private void Start()
    {
        //hpSlider.value = (float)hp / (float)maxHp;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Shooting());
    }

    void Update()
    {
        Move();

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);

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
               SceneManager.LoadScene(nextSceneName);
              
               
            }
        }
    }


    //private void OnTriggerEnter2D(Collider collision)
    //{
    //    if(collision.gameObject.tag == "Boder")
    //    {
    //        switch (collision.gameObject.name)
    //        {
    //            case "Top":
    //                isTOuchTop = true;
    //                break;
    //            case "Bottom":
    //                isTOuchBottom = true;
    //                break ;
    //            case "Right":
    //                isTOuchRight = true;
    //                break;
    //            case "Left":
    //                isTOuchLeft = true;
    //                break;

    //        }
    //    }
    //}
}