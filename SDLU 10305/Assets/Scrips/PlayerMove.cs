using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    public float shootDuration = 0.8f;
    public float hp = 1;
    

    public GameObject bullet = null;
    
    // Start is called before the first frame update
    void Start()
    {
        
       // StartCoroutine(Shooting());
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        destroy();
    }
    public void Move()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(hori, verti).normalized * speed * Time.deltaTime);
    }
    private IEnumerator Shooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootDuration);
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hp = hp - 0.4f;
    }
    private void destroy()
    {
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
        

}
