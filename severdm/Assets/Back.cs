using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float scrollRange = 20f;
    [SerializeField]
    private float movespeed = 3.0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.down;
     
   private void Update()
    {
        transform.position += moveDirection * movespeed * Time.deltaTime; 

        if(transform.position.y <= -scrollRange)
        {
            transform.position = target.position + Vector3.up * scrollRange; 
        }
    }
}
