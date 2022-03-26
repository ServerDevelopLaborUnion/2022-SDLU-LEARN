using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField]

    public float _speed = 5f;

    private Rigidbody2D _rb = null;

    private Transform _transform = null;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        RigidMove();
        //Move();
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
    //    float hori = Input.GetAxisRaw("Horizontal");
    //    float verti = Input.GetAxisRaw("Vertical");

    //    Vector2 dir = hori * transform.right + verti * transform.up;

    //    _transform.Translate(dir.normalized * Time.deltaTime * _speed);
    //}
}
