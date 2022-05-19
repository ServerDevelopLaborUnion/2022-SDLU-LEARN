using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class way : EntityBase
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Dead();
    }
}
