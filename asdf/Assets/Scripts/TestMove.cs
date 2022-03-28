using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    //private public 
    [SerializeField] 
    private float _speed = 5f; // 전역변수 앞에 언더바 붙이는건 국룰이라고함
    private Rigidbody2D _rb = null; // null은 정말 아무것도 없는 빈 값
    private Transform _transform = null;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); //rb에 Rigidbody2D 를 불러옴
        _transform = transform; 

    }

    void Update()
    {
        //Move();
        RigidMove();
    }
    private void RigidMove()
    {

        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(hori, verti);
        _rb.velocity = dir * _speed;

    }

    //private void Move()
    //{
        //float hori = Input.GetAxisRaw("Horizontal");
        //float verti = Input.GetAxisRaw("Vertical");

        //Vector2 dir = hori * _transform.right + verti * _transform.up;
        //_transform.Translate(dir.normalized * Time.deltaTime * _speed);
    //}
}
