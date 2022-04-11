using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float shootDuration = 1f;
    public GameObject enemybullet = null;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shooting());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Shooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootDuration);
            Instantiate(enemybullet, transform.position, Quaternion.identity);
        }
    }
}
