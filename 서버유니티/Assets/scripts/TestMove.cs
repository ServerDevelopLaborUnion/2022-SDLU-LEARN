using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;

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
        //        Move();
    }

    private void RigidMove()
    {
        float hori = Input.GetAxisRaw("Horizontal");//ÁÂ¿ì
        float verti = Input.GetAxisRaw("Vertical");//À§¾Æ·¡
        _rb.velocity = new Vector2(hori, verti);
        
    }
}

//    private void Move()
//    {
//        //float hori = Input.GetAxisRaw("Horizontal");//ÁÂ¿ì
//        //float verti = Input.GetAxisRaw("Vertical");//À§¾Æ·¡


//        Vector2 dir = hori * _transform.right + verti * _transform.up;
//        _transform.Translate(dir.normalized * Time.deltaTime * _speed);
//    }

//}
