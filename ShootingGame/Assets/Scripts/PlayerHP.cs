using System.Collections;
using UnityEngine;
public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private float maxHp = 3;
    private float currentHP;  
    private SpriteRenderer spriteRenderer;

    public float MaxHP => maxHp;
    public float CurrentHP => currentHP;

    
    private void Awake()
    {
        currentHP = maxHp;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

public void TakeDamage(float damage)
{
    currentHP -= damage;

    StopCoroutine("HitColorAnimaion");
    StartCoroutine("HitColorAnimaion");

    if  ( currentHP <= 0 )
    {
        Debug.Log("Player HP : 0.. Die");
        Destroy(gameObject);
        
        
    }
}
private IEnumerator HitColorAnimaion()
{
    spriteRenderer.color = Color.red;
    yield return new WaitForSeconds(0.1f);
    spriteRenderer.color = Color.white;

}
}