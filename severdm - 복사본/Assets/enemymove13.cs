using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove13 : MonoBehaviour
{
    //private
    //protected override void Start()
    //{
    //    speed = 10;

    //}
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }


}
