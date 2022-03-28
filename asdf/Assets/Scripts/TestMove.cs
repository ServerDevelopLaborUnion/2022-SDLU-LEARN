using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    //private public 
    [SerializeField] 
    private float _speed = 5f; // �������� �տ� ����� ���̴°� �����̶����
    private Rigidbody2D _rb = null; // null�� ���� �ƹ��͵� ���� �� ��
    private Transform _transform = null;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); //rb�� Rigidbody2D �� �ҷ���
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
