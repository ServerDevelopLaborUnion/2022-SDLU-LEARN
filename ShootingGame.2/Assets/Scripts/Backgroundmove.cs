using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundmove : MonoBehaviour
{
    public float speed = 3f;
    private MeshRenderer meshRenderer = null;

    private Vector2 offset = Vector2.zero;
    
    
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset.x += speed * Time.deltaTime;
        meshRenderer.material.SetTextureOffset("_MainTex", offset);
    }
}