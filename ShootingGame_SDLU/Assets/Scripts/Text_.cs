using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_ : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnDisable();
    }

    public void TextMove()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    public void DestroyText()
    {
        Destroy(gameObject, 5f);
    }

    void OnDisable()
    {
        Application.Quit();
    }
}
