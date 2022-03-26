using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    public float _speed = 5f;

    private Rigidbody2D _rb = null;

    private Transform _transform = null;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Move();
        MoveRigid();
    }

    private void MoveRigid()
    {
        float hori = Input.GetAxisRaw("horizontal");
        float verti = Input.GetAxisRaw("vertical");

        Vector2 dir = new Vector2(hori, verti);
        _rb.velocity = dir * _speed;
    }

    //private void Move()
    //{
    //    float hori = Input.GetAxisRaw("horizontal");
    //    float verti = Input.GetAxisRaw("vertical");

    //    Vector2 dir = hori * _transform.right + verti * _transform.up;

    //    _transform.Translate(dir.normalized * Time.deltaTime * _speed);
    //}
}
