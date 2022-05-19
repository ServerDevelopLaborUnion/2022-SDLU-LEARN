using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBase : MonoBehaviour
{
    protected virtual void Start()
    {
        
    }
    protected virtual void Dead()
    {
        Debug.Log("사망");
        Destroy(gameObject);
    }
}