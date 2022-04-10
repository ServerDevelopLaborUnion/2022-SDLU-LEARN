using System.Collections;
using UnityEngine;
public class PlayerHP : MonoBehaviour
{
    public float speed = 5;
    [SerializeField]
    private float maxHp = 3;
    private float currentHP;  
    private SpriteRenderer spriteRenderer;
    private PlayerMove playermove;

    public float MaxHP => maxHp;
    public float CurrentHP => currentHP;

    
    private void Awake()
    {
        currentHP = maxHp;  
        spriteRenderer = GetComponent<SpriteRenderer>();
        playermove = GetComponent<PlayerMove>();
    }

public void TakeDamage(float damage)
{
    currentHP -= damage;

    StopCoroutine("HitColorAnimaion");
    StartCoroutine("HitColorAnimaion");
    if ( currentHP <= 0 )
    {
        playermove.Ondie();
    }   
}

private IEnumerator HitColorAnimaion()
{
    spriteRenderer.color = Color.red;
    yield return new WaitForSeconds(0.1f);
    spriteRenderer.color = Color.white;

}
}