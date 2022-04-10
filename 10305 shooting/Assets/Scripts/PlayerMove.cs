using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Slider LifeGage;
    private float maxHp = 100;
    private float curHp = 100;
    public int life;
    public int score;
    public float speed = 10f;
    void Start()
    {
        LifeGage.value = (float)curHp / (float)maxHp;
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(h, v, 0);
        transform.position += dir * speed * Time.deltaTime;
       
        HandleHp();
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void Hpgage()
    {
        life -= 1;
        curHp -= 34;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Hpgage();
        }
    }
    private void HandleHp()
    {
        LifeGage.value = (float)curHp / (float)maxHp;
    }
}
