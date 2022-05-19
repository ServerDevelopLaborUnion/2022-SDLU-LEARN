using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EntityBase
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        Debug.Log("돌아가");
    }
}
