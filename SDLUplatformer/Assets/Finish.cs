using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : EntityBase
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Dead();
        Destroy(other.gameObject);
    }
}
