using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : EntityBase
{
    Vector3 dir;
    float speed = 5;
    private Collider2D _col = null;
    protected override void Start()
    {
        base. Start();
        _col = GetComponent<Collider2D>();
    }
    private void Update()
    {
        Move();
    }
    private void Move(){
        float h = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(h,0,0);
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       
    }
    
}
