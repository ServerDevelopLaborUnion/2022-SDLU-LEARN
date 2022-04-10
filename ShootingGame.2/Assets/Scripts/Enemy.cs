using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.CompareTag("Player") )
        {
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            Destroy(gameObject); 
        }
    }
}
