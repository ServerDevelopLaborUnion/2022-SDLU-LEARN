using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EntityBase
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Dead();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
